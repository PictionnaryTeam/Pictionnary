﻿using Pictionnary.Handlers;
using Pictionnary.Objects;
using Pictionnary.Objects.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Managers
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
