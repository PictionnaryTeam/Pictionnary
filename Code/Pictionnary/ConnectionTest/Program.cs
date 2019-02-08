using ConnectionTest.Managers;
using ConnectionTest.Objects.Packets.Client;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConnectionTest
{
    class Program
    {
        public static PacketManager packetManager;
        public static Random random;
        public static TCPServer server;

        static void Main(string[] args)
        {
            packetManager = new PacketManager();
            random = new Random();
            
            /*
            server = new TCPServer("localhost", 32323);
            server.Start();
            */

            TCPClient.ServerIP = "172.16.30.81";
            TCPClient.ServerPort = 32323;
            if(TCPClient.SendPacket(new ClientRegisterPacket(server)) == null)
            {
                Console.WriteLine("OUPS");
            }

            /*
            TCPClient.SendPacket(new ClientSendPointsPacket(new List<Point>()));
            */
        }
    }
}
