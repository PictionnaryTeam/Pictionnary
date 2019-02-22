using Pictionnary.Networking;
using Pictionnary.Networking.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pictionnary.Forms;
using Pictionnary.Other;

namespace Pictionnary
{
    static class Program
    {
        public static PacketManager packetManager;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            packetManager = new PacketManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormManager.InitializeForms();
            Application.Run(FormManager.homeView);
        }
    }
}
