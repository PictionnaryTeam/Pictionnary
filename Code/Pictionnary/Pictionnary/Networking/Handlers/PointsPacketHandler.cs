using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking.Handlers
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
