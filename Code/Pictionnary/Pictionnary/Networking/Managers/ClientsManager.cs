using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Managers
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

        public static NetworkError RegisterClient(TCPServer client, string password)
        {
            if (Program.netHelper.Server.Room == null)
            {
                return NetworkError.NoRoomStarted;
            }

            if (Program.netHelper.Server.Room.Password != "")
            {
                if (Program.netHelper.Server.Room.Password != password)
                {
                    return NetworkError.BadPassword;
                }
            }

            if (client == null)
            {
                return NetworkError.NullClientSent;
            }

            if (_clients == null)
            {
                _clients = new List<TCPServer>();
            }

            _clients.Add(client);

            return NetworkError.None;
        }

        public static NetworkError RemoveClient(TCPServer client)
        {
            if (client == null)
            {
                return NetworkError.NullClientSent;
            }

            if (_clients == null)
            {
                _clients = new List<TCPServer>();
            }

            _clients.Remove(client);

            return NetworkError.None;
        }
    }
}
