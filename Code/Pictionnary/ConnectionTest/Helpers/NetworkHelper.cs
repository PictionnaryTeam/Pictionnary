using Pictionnary.Objects.Packets;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pictionnary.Helpers
{
    class NetworkHelper
    {
        /// <summary>
        /// Gets the actual pc local machine
        /// </summary>
        /// <returns>Application local adress</returns>
        public static String GetLocalAdress()
        {
            //using socket on internetowrk target
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                //connect to anycast ip
                socket.Connect("8.8.8.8", 65530);

                //get local endpoint
                IPEndPoint localEndPoint = socket.LocalEndPoint as IPEndPoint;
                return localEndPoint.Address.ToString();
            }
        }

        /// <summary>
        /// Serializes the packet.
        /// </summary>
        /// <returns>The packet.</returns>
        /// <param name="packet">Packet.</param>
        public static byte[] SerializePacket(Packet packet)
        {
            //new instance of stream and byte formatter
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter byteFormatter = new BinaryFormatter();

            //serialize the packet
            byteFormatter.Serialize(memoryStream, packet);

            //return serialized bytes
            return memoryStream.ToArray();
        }

        /// <summary>
        /// Deserializes the packet.
        /// </summary>
        /// <returns>The packet.</returns>
        /// <param name="data">Packet Data.</param>
        public static Packet DeserializePacket(byte[] data)
        {
            //new instance of stream and byte formatter
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryFormatter byteFormatter = new BinaryFormatter();

            //deserialize as packet
            Packet deserializedPacket = byteFormatter.Deserialize(memoryStream) as Packet;

            return deserializedPacket;
        }
    }
}
