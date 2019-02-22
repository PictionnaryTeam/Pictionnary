using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    [Serializable]
    class ClientSendChatMessageEventPacket : Packet
    {
        string _sender;
        string _message;
        DateTime _time;

        public ClientSendChatMessageEventPacket(string sender, string message) : base(PacketType.CLIENTPACKETSENDCHATMESSAGEEVENT)
        {
            _sender = sender;
            _message = message;
            _time = DateTime.Now;
        }

        public string Sender { get => _sender; set => _sender = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Time { get => _time; set => _time = value; }
    }
}
