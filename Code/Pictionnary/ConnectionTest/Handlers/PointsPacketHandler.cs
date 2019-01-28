using ConnectionTest.Managers;
using ConnectionTest.Objects;
using ConnectionTest.Objects.Packets;
using ConnectionTest.Objects.Packets.Server;

namespace ConnectionTest.Handlers
{
    class PointsPacketHandler : PacketReceiveHandler
    {
        public PointsPacketHandler()
        {

        }

        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientsManager.SendPacketToEveryClients(receivedPacket);

            return new ServerConfirmationPacket();
        }
    }
}
