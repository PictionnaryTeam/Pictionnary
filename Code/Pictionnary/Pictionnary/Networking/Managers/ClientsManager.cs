using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Managers
{
    static class ClientsManager
    {
        static List<TCPServerInfos> _clients;

        public static async Task SendPacketToEveryClients(Packet packet)
        {
            lock (_clients)
            {
                if (_clients != null)
                {
                    foreach (TCPServerInfos server in _clients)
                    {
                        TCPClient.ReSendPacket(packet, server.ServerIP, server.ServerPort);
                    }
                } 
            }
        }

        public static NetworkError RegisterClient(TCPServerInfos client, string password)
        {
            if (NetworkingHelper.GetInstance().Server.Room == null)
            {
                return NetworkError.NoRoomStarted;
            }

            if (NetworkingHelper.GetInstance().Server.Room.Password != "")
            {
                if (NetworkingHelper.GetInstance().Server.Room.Password != password)
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
                _clients = new List<TCPServerInfos>();
            }

            _clients.RemoveAll(x => x.ServerIP == client.ServerIP);

            _clients.Add(client);

            return NetworkError.None;
        }

        public static NetworkError RemoveClient(TCPServerInfos client)
        {
            if (client == null)
            {
                return NetworkError.NullClientSent;
            }

            if (_clients == null)
            {
                _clients = new List<TCPServerInfos>();
            }

            _clients.Remove(client);

            return NetworkError.None;
        }
    }
}
