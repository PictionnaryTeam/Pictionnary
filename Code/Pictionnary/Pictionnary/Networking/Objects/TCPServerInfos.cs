using Pictionnary.GameClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Objects
{
    [Serializable]
    class TCPServerInfos
    {
        //Server informations
        String serverIP;
        int serverPort;

        string name;

        //Actual room
        Room room;


        public TCPServerInfos(string serverIP, int serverPort, Room room, string name)
        {
            this.serverIP = serverIP;
            this.serverPort = serverPort;
            this.room = room;
            this.name = name;
        }


        //Public
        public string ServerIP { get => serverIP; set => serverIP = value; }
        public int ServerPort { get => serverPort; set => serverPort = value; }
        public string Name { get => name; set => name = value; }
        internal Room Room { get => room; set => room = value; }
    }
}
