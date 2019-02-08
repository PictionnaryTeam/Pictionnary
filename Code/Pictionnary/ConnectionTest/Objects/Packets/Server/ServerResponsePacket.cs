using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Objects.Packets.Server
{
    [Serializable]
    class ServerResponsePacket : Packet
    {
        NetworkError error;

        public ServerResponsePacket(NetworkError error) : base(PacketType.SERVERPACKETCONFIRMATION)
        {
            this.error = error;
        }

        public NetworkError Error { get => error; set => error = value; }
    }
}
