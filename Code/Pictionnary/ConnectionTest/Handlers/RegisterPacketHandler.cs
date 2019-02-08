using Pictionnary.Managers;
using Pictionnary.Objects;
using Pictionnary.Objects.Packets;
using Pictionnary.Objects.Packets.Client;
using Pictionnary.Objects.Packets.Server;

namespace Pictionnary.Handlers
{
    class RegisterPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientsManager.RegisterClient((receivedPacket as ClientRegisterPacket).Client);
            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
