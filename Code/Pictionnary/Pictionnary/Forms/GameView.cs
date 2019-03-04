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
        DrawingEditor.DrawingCanvasTemplate _drawawableCanvas;

        // "toile" sur laquelle on peut afficher les dessins
        Panel _renderOnlyCanvas;

        public GameView()
        {
            InitializeComponent();

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
    }
}
