using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    [Serializable]
    class ClientRegisterPacket : Packet
    {
        TCPServerInfos _client;
        String _password;

        public ClientRegisterPacket(TCPServerInfos client, string password) : base(PacketType.CLIENTREGISTER)
        {
            _client = client;
            Password = password;
        }

        public string Password { get => _password; set => _password = value; }
        internal TCPServerInfos Client { get => _client; set => _client = value; }
    }
}
