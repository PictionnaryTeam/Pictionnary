using Pictionnary.Networking;
using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects.EventArgs;
using Pictionnary.Networking.Objects.Packets.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictionnary.Forms
{
    public partial class GameView : Form
    {
        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();

        public GameView()
        {
            InitializeComponent();

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
            lblChat.Invoke(new MethodInvoker(() => { lblChat.Text += ($"{e.Sender} ({e.Time.ToShortTimeString()}) : {e.Message}\n"); }));
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            NetworkingHelper.GetInstance().SendMessageToChat("HALLO");
        }
    }
}
