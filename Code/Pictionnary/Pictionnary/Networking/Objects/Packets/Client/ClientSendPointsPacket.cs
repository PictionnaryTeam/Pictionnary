using DrawingEditor;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    [Serializable]
    class ClientSendPointsPacket : Packet
    {
        Drawing _points;
        public ClientSendPointsPacket(Drawing points) : base(PacketType.CLIENTPACKETPING)
        {
            _points = points;
        }

        public Drawing Points { get => _points; set => _points = value; }
    }
}
