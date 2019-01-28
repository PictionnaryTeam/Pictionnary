using ConnectionTest.Managers;
using ConnectionTest.Objects.Packets.Client;
using System;

namespace ConnectionTest
{
    class Program
    {
        public static PacketManager packetManager;
        public static Random random;

        static void Main(string[] args)
        {
            packetManager = new PacketManager();
            random = new Random();

            TCPServer server = new TCPServer("127.0.0.1", 32323);
            server.Start();

            TCPClient client = new TCPClient("127.0.0.1", 32323);
            client.SendPacket(new ClientPingPacket());
        }
    }
}
