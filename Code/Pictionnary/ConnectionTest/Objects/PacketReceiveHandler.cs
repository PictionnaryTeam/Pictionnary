﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest.Objects
{
    abstract class PacketReceiveHandler
    {
        public abstract Packets.Packet OnPacketReceive(Packets.Packet receivedPacket);
    }
}