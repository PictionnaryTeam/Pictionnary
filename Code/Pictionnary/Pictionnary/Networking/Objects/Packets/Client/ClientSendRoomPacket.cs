using Pictionnary.GameClasses;
using System;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    [Serializable]
    class ClientSendRoomPacket : Packet
    {
        Room game;

        public ClientSendRoomPacket(Room game) : base(PacketType.CLIENTPACKETSENDROOM)
        {
            this.Game = game;
        }

        public Room Game { get => game; set => game = value; }
    }
}
