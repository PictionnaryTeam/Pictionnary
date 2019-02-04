using ConnectionTest.Managers;
using ConnectionTest.Objects;
using ConnectionTest.Objects.Packets;
using ConnectionTest.Objects.Packets.Client;
using ConnectionTest.Objects.Packets.Server;

namespace ConnectionTest.Handlers
{
    class RegisterPacketHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientsManager.RegisterClient((receivedPacket as ClientRegisterPacket).Client);
            return new ServerConfirmationPacket();
        }
    }
}
