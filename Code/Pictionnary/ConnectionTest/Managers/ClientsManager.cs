using Pictionnary.Objects.Packets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pictionnary.Managers
{
    static class ClientsManager
    {
        static List<TCPServer> _clients;

        public static async Task SendPacketToEveryClients(Packet packet)
        {
            lock (_clients)
            {
                if (_clients != null)
                {
                    foreach (TCPServer server in _clients)
                    {
                        TCPClient.ReSendPacket(packet, server.ServerIP, server.ServerPort);
                    }
                } 
            }
        }

        public static void RegisterClient(TCPServer client)
        {
            if (_clients == null)
            {
                _clients = new List<TCPServer>();
            }

            _clients.Add(client);
        }

        public static void RemoveClient(TCPServer client)
        {
            if (_clients == null)
            {
                _clients = new List<TCPServer>();
            }

            _clients.Remove(client);
        }
    }
}
