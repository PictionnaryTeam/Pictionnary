using Pictionnary.Networking;
<<<<<<< HEAD
using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects.EventArgs;
using Pictionnary.Networking.Objects.Packets.Client;
=======
using Pictionnary.Other;
>>>>>>> 2d87e423cf6bbe735a7a3352462db8b2746356ca
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pictionnary.Forms
{
    public partial class GameView : Form
    {
        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();

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

<<<<<<< HEAD
        private void GameView_Load(object sender, EventArgs e)
        {

        }

        private void OnMessageReceive(OnChatMessageReceiveEventArgs e)
        {
            lblChat.Invoke(new MethodInvoker(() => { lblChat.Text += ($"{e.Sender} ({e.Time.ToShortTimeString()}) : {e.Message}\n"); }));
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            NetworkingHelper.GetInstance().SendMessageToChat("HALLO");
=======

        void Tbx_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredText = tbxChat.Text;

                string wordToFind = NetworkingHelper.GetInstance().Server.Room.Word;

                if (enteredText.RefactorText() == wordToFind.RefactorText())
                {
                    //Show to everyone that he found the word
                    //{player.Name} a trouvé le mot
                }
                else
                {
                    //Show to everyone the word that the player tried by using entered text
                    //{player.Name} a proposé le mot {enteredText}
                }

                tbxChat.Text = "";
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
>>>>>>> 2d87e423cf6bbe735a7a3352462db8b2746356ca
        }
    }
}
