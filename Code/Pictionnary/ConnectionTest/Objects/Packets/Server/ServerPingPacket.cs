using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest.Objects.Packets.Server
{
    [Serializable]
    class ServerPingPacket : Packet
    {
        public ServerPingPacket() : base(PacketType.SERVERPACKETPING)
        {
        }
    }
}
