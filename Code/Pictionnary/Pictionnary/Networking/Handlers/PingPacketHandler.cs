using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking.Handlers
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
