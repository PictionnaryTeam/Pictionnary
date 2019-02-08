using Pictionnary.Objects;
using Pictionnary.Objects.Packets;
using Pictionnary.Objects.Packets.Server;
using Pictionnary.Managers;

namespace Pictionnary.Handlers
{
    class SendRoomPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientsManager.SendPacketToEveryClients(receivedPacket);
            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
