using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Client;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking.Handlers
{
    class UnregisterPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            NetworkError error = ClientsManager.RemoveClient((receivedPacket as ClientUnregisterPacket).Client);

            return new ServerResponsePacket(error);
        }
    }
}
