using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking.Handlers
{
    class RequestRoomPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            return new ServerSendRoomPacket(Program.netHelper.Server.Room);
        }
    }
}
