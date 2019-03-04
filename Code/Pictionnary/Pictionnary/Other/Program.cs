using Pictionnary.Networking.Managers;
using Pictionnary.Other;
using System;
using System.Windows.Forms;

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
