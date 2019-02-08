using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Objects.Packets
{
    [Serializable]
    abstract class Packet
    {
        PacketType packetType;                      //packet type

        public Packet(PacketType packetType)
        {
            //set local type
            this.packetType = packetType;
        }

        public PacketType PacketType { get => packetType; set => packetType = value; }
    }
}
