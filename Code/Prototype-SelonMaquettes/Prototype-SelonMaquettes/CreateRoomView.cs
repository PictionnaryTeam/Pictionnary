using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_SelonMaquettes
{
    public partial class CreateRoomView : Form
    {
        public CreateRoomView()
        {
            InitializeComponent();
            Icon = Prototype_SelonMaquettes.Properties.Resources.Icon;
        }

        private void numUpDownTimeLimit_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;

      

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if(checkBox.Checked)
            {
                numUpDownLimitPlayers.Enabled = true;
            }
            else
            {
                numUpDownLimitPlayers.Enabled = false;
            }
        }

        private void chkBoxGamesLimit_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                chkBoxGamesLimit.Enabled = true;
            }
            else
            {
                chkBoxGamesLimit.Enabled = false;
            }
        }
    }
}
