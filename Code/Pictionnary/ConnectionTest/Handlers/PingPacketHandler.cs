using Pictionnary.Objects;
using Pictionnary.Objects.Packets;
using Pictionnary.Objects.Packets.Server;

namespace Pictionnary.Handlers
{
    class PingPacketHandler : PacketReceiveHandler
    {
        public PingPacketHandler()
        {

        }

        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
