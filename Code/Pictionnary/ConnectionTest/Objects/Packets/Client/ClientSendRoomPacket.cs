using System;

namespace Pictionnary.Objects.Packets.Client
{
    [Serializable]
    class ClientSendRoomPacket : Packet
    {
        Room room;

        public ClientSendRoomPacket(Room room) : base(PacketType.CLIENTPACKETSENDROOM)
        {
            this.Room = room;
        }

        public Room Room { get => room; set => room = value; }
    }
}
