using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    class ClientRequestRoomPacket : Packet
    {
        public ClientRequestRoomPacket() : base(PacketType.CLIENTPACKETREQUESTROOM)
        {

        }
    }
}
