using Pictionnary.Networking;
using Pictionnary.Networking.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictionnary
{
    static class Program
    {
        public static PacketManager packetManager;
        public static NetworkingHelper netHelper;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            packetManager = new PacketManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
