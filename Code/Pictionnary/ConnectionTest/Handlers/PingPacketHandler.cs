using ConnectionTest.Objects;
using ConnectionTest.Objects.Packets;
using ConnectionTest.Objects.Packets.Server;

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
