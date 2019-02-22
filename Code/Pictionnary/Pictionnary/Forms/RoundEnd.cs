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
    public partial class RoundEnd : Form
    {
        public RoundEnd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Goes to the game end view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            FormManager.gameEnd.Show();
            Hide();
        }
    }
}
