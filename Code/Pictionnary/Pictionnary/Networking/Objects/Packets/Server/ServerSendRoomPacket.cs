using Pictionnary.GameClasses;

namespace Pictionnary.Networking.Objects.Packets.Server
{
    class ServerSendRoomPacket : Packet
    {
        private Room room;

        public ServerSendRoomPacket(Room room) : base(PacketType.SERVERPACKETSENDROOM)
        {
            this.room = room;
        }

        internal Room Room { get => room; set => room = value; }
    }
}
