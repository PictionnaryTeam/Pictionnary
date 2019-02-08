using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest.Objects.Packets.Server
{
    [Serializable]
    class ServerConfirmationPacket : Packet
    {
        public ServerConfirmationPacket() : base(PacketType.SERVERPACKETCONFIRMATION)
        {
        }
    }
}
