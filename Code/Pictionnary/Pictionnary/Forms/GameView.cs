using Pictionnary.Networking;
using Pictionnary.Other;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pictionnary.Forms
{
    public partial class GameView : Form
    {
        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();

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
        }


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
        }
    }
}
