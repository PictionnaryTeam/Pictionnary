using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Objects.Packets.Client
{
    [Serializable]
    class ClientPingPacket : Packet
    {
        public ClientPingPacket() : base(PacketType.CLIENTPACKETPING)
        {
        }
    }
}
