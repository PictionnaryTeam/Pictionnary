using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Objects.Packets.Client
{
    [Serializable]
    class ClientRegisterPacket : Packet
    {
        TCPServer _client;
        public ClientRegisterPacket(TCPServer client) : base(PacketType.CLIENTREGISTER)
        {
            _client = client;
        }

        internal TCPServer Client { get => _client; set => _client = value; }
    }
}
