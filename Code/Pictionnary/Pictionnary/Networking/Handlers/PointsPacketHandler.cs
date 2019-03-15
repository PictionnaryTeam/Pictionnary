using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Client;
using Pictionnary.Networking.Objects.Packets.Server;
using Pictionnary.Other;

namespace Pictionnary.Networking.Handlers
{
    class PointsPacketHandler : PacketReceiveHandler
    {
        public PointsPacketHandler()
        {

        }

        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            FormManager.gameView.SetDrawing((receivedPacket as ClientSendPointsPacket).Points);

            ClientsManager.SendPacketToEveryClients(receivedPacket);

            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
