using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Client;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking.Handlers
{
    class RegisterPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            NetworkError error = ClientsManager.RegisterClient((receivedPacket as ClientRegisterPacket).Client, (receivedPacket as ClientRegisterPacket).Password);
            return new ServerResponsePacket(error);
        }
    }
}
