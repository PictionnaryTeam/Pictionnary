using ConnectionTest.Objects;
using ConnectionTest.Objects.Packets;
using ConnectionTest.Objects.Packets.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest.Handlers
{
    class PingPacketHandler : PacketReceiveHandler
    {
        public PingPacketHandler()
        {
        }

        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            return new ServerPingPacket();
        }
    }
}
