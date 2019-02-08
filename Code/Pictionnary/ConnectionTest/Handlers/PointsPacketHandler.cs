using Pictionnary.Managers;
using Pictionnary.Objects;
using Pictionnary.Objects.Packets;
using Pictionnary.Objects.Packets.Server;

namespace Pictionnary.Handlers
{
    class PointsPacketHandler : PacketReceiveHandler
    {
        public PointsPacketHandler()
        {

        }

        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientsManager.SendPacketToEveryClients(receivedPacket);

            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
