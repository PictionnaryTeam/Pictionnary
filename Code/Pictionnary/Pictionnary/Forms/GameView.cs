using Pictionnary.Networking;
using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects.EventArgs;
using Pictionnary.Other;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pictionnary.Forms
{
    public partial class GameView : Form
    {
        public int RoundAmount { get; set; }
        public bool UnlimitedRounds { get; set; }
        private int roundsPassed = 0;

        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();

        DateTime roundStartTime;
        DateTime gameProgressTime;
        TimeSpan timerTime;
        TimeSpan leftTime;
        int endRoundCounter = 0;
        double roundTimeSelected = 20;

        // Éditeur de dessin
        DrawingEditor.DrawingCanvasTemplate _drawingCanvas;

        // "toile" sur laquelle on peut afficher les dessins
        Panel _renderOnlyCanvas;

        bool _isCurrentClientDrawing;

        /// <summary>
        /// Permet d'afficher l'éditeur de dessin
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public GameView()
        {
            InitializeComponent();

            _drawingCanvas = new DrawingEditor.DrawingCanvasNormalMode();
            _drawingCanvas.Location = new System.Drawing.Point(182, 50);
            _drawingCanvas.Size = new System.Drawing.Size(616, 600);

            _renderOnlyCanvas = new Panel();
            _renderOnlyCanvas.BackColor = System.Drawing.Color.White;
            _renderOnlyCanvas.Size = new System.Drawing.Size(610, 460);
            _renderOnlyCanvas.Location = new System.Drawing.Point(185, 50);

            _isCurrentClientDrawing = true;
            updateDrawingMode();

            tbxChat.PreviewKeyDown += new PreviewKeyDownEventHandler(Tbx_KeyDown);

            List<string> listOfParams = new List<string>();

            foreach (string element in listOfParams)
            {
                MessageBox.Show(element);
            }

            EventsManager.OnChatMessageReceive += new EventsManager.OnChatMessageReceiveEventHandler(OnMessageReceive);
        }

        private void GameView_Load(object sender, EventArgs e)
        {

        }

        private void OnMessageReceive(OnChatMessageReceiveEventArgs e)
        {
            tbxChatContent.Invoke(new MethodInvoker(() => {
                tbxChatContent.Text += ($"{e.Sender} ({e.Time.ToShortTimeString()}) : {e.Message}\n");
                tbxChatContent.SelectionStart = tbxChatContent.Text.Length;
                tbxChatContent.ScrollToCaret();
            }));
        }

        private void Tbx_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbxChat.Text.Trim() != "")
            {
                string enteredText = tbxChat.Text;

                NetworkingHelper.GetInstance().SendMessageToChat(enteredText);

                tbxChat.Clear();
            }
        }

        private void updateDrawingMode()
        {
            if(_isCurrentClientDrawing)
            {
                Controls.Remove(_renderOnlyCanvas);
                Controls.Add(_drawingCanvas);
            }
            else
            {
                Controls.Remove(_drawingCanvas);
                Controls.Add(_renderOnlyCanvas);
            }
        }
        
        /// <summary>
        /// Goes to the round end view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopGame_Click(object sender, EventArgs e)
        {
            FormManager.roundEnd.Show();
            Hide();
        }

        private void StartRound()
        {
            roundTimer.Start();
            leftTime = TimeSpan.FromSeconds(roundTimeSelected);
            roundStartTime = DateTime.Now;
        }

        private void roundTimer_Tick(object sender, EventArgs e)
        {
            gameProgressTime = DateTime.Now;
            timerTime = leftTime - (gameProgressTime - roundStartTime);
            lblTimer.Text = (timerTime.Minutes.ToString("0#") + ":" + timerTime.Seconds.ToString("0#"));

            if (timerTime.Minutes == 0 && timerTime.Seconds == 0)
            {
                ++roundsPassed;
                roundTimer.Stop();

                if (roundsPassed == RoundAmount && !UnlimitedRounds)
                {
                    Hide();
                    FormManager.gameEnd.Show();
                }
                else
                {
                    Hide();
                    FormManager.roundEnd.Show();
                    endRoundTimer.Start();
                }
            }
        }

        private void endRoundTimer_Tick(object sender, EventArgs e)
        {
            endRoundCounter++;

            if (endRoundCounter == 15)
            {
                endRoundTimer.Stop();
                endRoundCounter = 0;
                FormManager.roundEnd.Hide();
                Show();
                roundTimer.Start();
                roundStartTime = DateTime.Now;
            }
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            if(!_isCurrentClientDrawing)
            {
                DrawingEditor.Drawing todraw = new DrawingEditor.Drawing();
                DrawingEditor.PanelRenderer renderer = new DrawingEditor.PanelRenderer(_renderOnlyCanvas);
                renderer.Render(todraw, e);
            }
        }
    }
}
