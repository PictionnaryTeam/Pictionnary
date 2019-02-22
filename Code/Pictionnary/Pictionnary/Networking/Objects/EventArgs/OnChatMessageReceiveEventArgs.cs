using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.Networking.Objects.EventArgs
{
    class OnChatMessageReceiveEventArgs
    {
        string _sender;
        string _message;
        DateTime _time;

        public OnChatMessageReceiveEventArgs(string sender, string message, DateTime time)
        {
            _sender = sender;
            _message = message;
            _time = time;
        }

        public string Sender { get => _sender; set => _sender = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Time { get => _time; set => _time = value; }
    }
}
