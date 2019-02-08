using Pictionnary.Networking.Handlers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using System.Collections.Generic;

namespace Pictionnary.Networking.Managers
{
    class PacketManager
    {
        Dictionary<PacketType, PacketReceiveHandler> packetHandlers;

        public PacketManager()
        {
            packetHandlers = new Dictionary<PacketType, PacketReceiveHandler>();

            AddHandler(PacketType.CLIENTPACKETPING, new PingPacketHandler());
            AddHandler(PacketType.CLIENTPACKETPOINTS, new PointsPacketHandler());
            AddHandler(PacketType.CLIENTREGISTER, new RegisterPacketHandler());
            AddHandler(PacketType.CLIENTPACKETSENDROOM, new SendRoomPacketHandler());
            AddHandler(PacketType.CLIENTPACKETREQUESTROOM, new RequestRoomPacketHandler());
            AddHandler(PacketType.CLIENTPACKETUNREGISTER, new UnregisterPacketHandler());
        }

        public void AddHandler(PacketType packetType, PacketReceiveHandler handler)
        {
            packetHandlers.Add(packetType, handler);
        }

        public Packet HandleReceivedPacket(Packet packet)
        {
            return packetHandlers[packet.PacketType].OnPacketReceive(packet);
        }
    }
}
