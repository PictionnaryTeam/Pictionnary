using Pictionnary.Networking.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Server;
using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects.Packets.Client;

namespace Pictionnary.Networking.Handlers
{
    class SendMessageInChatHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            EventsManager.OnChatMessageReceive?.Invoke(new Objects.EventArgs.OnChatMessageReceiveEventArgs(
                (receivedPacket as ClientSendChatMessageEventPacket).Sender, 
                (receivedPacket as ClientSendChatMessageEventPacket).Message, 
                (receivedPacket as ClientSendChatMessageEventPacket).Time)
            );

            ClientsManager.SendPacketToEveryClients(receivedPacket);

            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
