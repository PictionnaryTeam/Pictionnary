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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            //Icon = Prototype_SelonMaquettes.Properties.Resources.Icon;
            ActiveControl = lblTitle;
        }

        /// <summary>
        /// Goes to the create room view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            FormManager.createRoomView.Show();
            Hide();
        }

        /// <summary>
        /// Goes to the join room view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            FormManager.joinRoomView.Show();
            Hide();
        }
    }
}
