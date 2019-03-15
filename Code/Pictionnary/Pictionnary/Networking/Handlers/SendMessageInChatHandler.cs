using Pictionnary.GameClasses;
using Pictionnary.Networking.Managers;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets;
using Pictionnary.Networking.Objects.Packets.Client;
using Pictionnary.Networking.Objects.Packets.Server;
using Pictionnary.Other;

namespace Pictionnary.Networking.Handlers
{
    class SendMessageInChatHandler : PacketReceiveHandler
    {
        public override Packet OnPacketReceive(Packet receivedPacket)
        {
            ClientSendChatMessageEventPacket p = (receivedPacket as ClientSendChatMessageEventPacket);

            //string wordToFind = NetworkingHelper.GetInstance().Server.Room.Word;

            //if (p.Message.RefactorText() == wordToFind.RefactorText())
            //{
            //    //Show to everyone that he found the word
            //    p.Message = $"{p.Time.ToShortTimeString()} : {p.Sender} a trouvé le mot";

            //    ScoreManager.GetInstance().PlayerFoundWord(p.Sender, p.Time);
            //}

            EventsManager.OnChatMessageReceive?.Invoke(new Objects.EventArgs.OnChatMessageReceiveEventArgs(
                p.Sender,
                p.Message,
                p.Time)
            );

            ClientsManager.SendPacketToEveryClients(receivedPacket);

            return new ServerResponsePacket(NetworkError.None);
        }
    }
}
