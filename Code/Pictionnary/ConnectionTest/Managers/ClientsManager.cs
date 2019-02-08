using ConnectionTest.Objects.Packets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectionTest.Managers
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
            _clients.Add(client);
        }

        public static void RemoveClient(TCPServer client)
        {
            _clients.Remove(client);
        }
    }
}
