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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            Icon = Prototype_SelonMaquettes.Properties.Resources.Icon;
            ActiveControl = lblTitle;
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            ChangeForm change = new ChangeForm();

            change.ChangeOfForm(this, Forms.createRoom);
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            ChangeForm change = new ChangeForm();

            change.ChangeOfForm(this, Forms.enterRoom);
        }
    }
}
