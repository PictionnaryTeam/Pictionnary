using Pictionnary.Networking;
using Pictionnary.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pictionnary.Other;

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
        }
        
        
        void Tbx_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string enteredText = tbxChat.Text;

<<<<<<< HEAD
                string wordToFind = NetworkingHelper.GetInstance().Server.Room.Word;

                if(enteredText.RefactorText() == wordToFind.RefactorText())
                {
                    //Show to everyone that he found the word
                }
                else
                {
                    //Show to everyone the word that the player tried by using entered text
                }

                tbxChat.Text = "";
            }
=======
        /// <summary>
        /// Goes to the round end view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopGame_Click(object sender, EventArgs e)
        {
            FormManager.roundEnd.Show();
            Hide();
>>>>>>> 5162f26072a095fb3000a32137af0fd5b296a1a3
        }
    }
}
