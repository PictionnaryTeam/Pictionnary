using Pictionnary.Objects.Packets.Client;
using Pictionnary.Objects.Packets.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary
{
    class NetworkingHelper
    {
        TCPClient _client;
        TCPServer _server;

        public NetworkingHelper()
        {
            _server = new TCPServer("localhost", 32323);

            TCPClient.ServerPort = 32323;
        }

        public bool Ping(string ip)
        {
            ServerResponsePacket result = TCPClient.SendPacket(new ClientPingPacket(), ip, TCPClient.ServerPort) as ServerResponsePacket;

            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool TryToRegister(string ip, string password = "")
        {
            ServerResponsePacket result = TCPClient.SendPacket(new ClientRegisterPacket(_server));
        }
    }
}
