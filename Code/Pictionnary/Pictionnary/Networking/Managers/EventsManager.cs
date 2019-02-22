using Pictionnary.Networking.Objects.EventArgs;

namespace Pictionnary.Networking.Managers
{
    static class EventsManager
    {
        //-----------------------Delegates---------------------------
        public delegate void OnChatMessageReceiveEventHandler(OnChatMessageReceiveEventArgs e);



        //------------------------Events-----------------------------
        public static OnChatMessageReceiveEventHandler OnChatMessageReceive;
    }
}
