using Pictionnary.GameClasses;
using Pictionnary.Networking.Objects;
using Pictionnary.Networking.Objects.Packets.Client;
using Pictionnary.Networking.Objects.Packets.Server;

namespace Pictionnary.Networking
{
    class NetworkingHelper
    {
        TCPClient _client;
        TCPServer _server;

        /// <summary>
        /// [Warning] Do not edit if not sure
        /// </summary>
        internal TCPClient Client { get => _client; set => _client = value; }

        /// <summary>
        /// [Warning] Do not edit if not sure
        /// </summary>
        internal TCPServer Server { get => _server; set => _server = value; }


        /// <summary>
        /// Create a new instance of the <see cref="NetworkingHelper"/> class
        /// </summary>
        public NetworkingHelper()
        {
            //Init server
            _server = new TCPServer("localhost", 32323);

            //In port
            TCPClient.ServerPort = 32323;
        }


        /// <summary>
        /// Ping an ip (check if server if started on ip host)
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool Ping(string ip)
        {
            //Send packet and get response
            ServerResponsePacket result = TCPClient.SendPacket(new ClientPingPacket(), ip, TCPClient.ServerPort) as ServerResponsePacket;

            //Return null or not
            return result != null;
        }


        /// <summary>
        /// Try to register to room with ip and password
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public NetworkError TryToRegister(string ip, string password = "")
        {
            //Send packet and get response
            ServerResponsePacket result = TCPClient.SendPacket(new ClientRegisterPacket(_server, password)) as ServerResponsePacket;

            //No result
            if (result == null)
            {
                //Unknown ip
                return NetworkError.UnknownIp;
            }
            else
            {
                //No error
                if (result.Error == NetworkError.None)
                {
                    //Save ip
                    TCPClient.ServerIP = ip;
                }

                //Return error
                return result.Error;
            }
        }


        /// <summary>
        /// Set local room
        /// </summary>
        /// <param name="room"></param>
        public void SetLocalRoom(Room room)
        {
            //Set values
            _server.Room = room;
        }


        /// <summary>
        /// Get room from the connected server
        /// </summary>
        /// <returns></returns>
        public Room GetConnectedServerRoom()
        {
            //Send packet and get response
            ServerSendRoomPacket response = TCPClient.SendPacket(new ClientRequestRoomPacket()) as ServerSendRoomPacket;

            //No result
            if (response == null)
            {
                //Null
                return null;
            }

            //Return error
            return response.Room;
        }


        /// <summary>
        /// Unregister from current registered room
        /// </summary>
        /// <returns></returns>
        public NetworkError UnregisterFromServer()
        {
            //Send packet and get response
            ServerResponsePacket response = TCPClient.SendPacket(new ClientUnregisterPacket(_server)) as ServerResponsePacket;

            //No result
            if (response == null)
            {
                //Unknown ip
                return NetworkError.UnknownIp;
            }

            //Return error
            return response.Error;
        }
    }
}
