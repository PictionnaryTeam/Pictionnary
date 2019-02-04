using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConnectionTest.Objects.Packets.Client
{
    [Serializable]
    class ClientSendPointsPacket : Packet
    {
        List<Point> _points;
        public ClientSendPointsPacket(List<Point> points) : base(PacketType.CLIENTPACKETPING)
        {
            _points = points;
        }

        public List<Point> Points { get => _points; set => _points = value; }
    }
}
