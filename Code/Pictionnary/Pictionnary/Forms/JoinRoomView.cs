using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pictionnary.Networking;

namespace Pictionnary.Forms
{
    public partial class JoinRoomView : Form
    {
        private NetworkingHelper network;
        private ChangeForm changeForm;


        public JoinRoomView()
        {
            network = NetworkingHelper.GetInstance();

            changeForm = new ChangeForm();

            InitializeComponent();
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
           switch(network.TryToRegister(txtBoxIPRoom.Text, txtBoxPassword.Text))
            {
                case Networking.Objects.NetworkError.BadPassword:
                    MessageBox.Show("Mauvais mot de passe", "Attention!");
                    break;

                case Networking.Objects.NetworkError.UnknownIp:
                case Networking.Objects.NetworkError.NoRoomStarted:
                    MessageBox.Show("IP pas disponible", "Attention!");
                    break;

                case Networking.Objects.NetworkError.None:
                    changeForm.ChangeOfForm(this, Other.DifferentForms.Game);
                    break;

                default:
                    MessageBox.Show("Impossible de rejoinde la room", "Attention!");
                    break;
            }
        }
    }
}
