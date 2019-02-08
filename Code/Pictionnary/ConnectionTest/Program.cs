using Pictionnary.Helpers;
using Pictionnary.Managers;
using Pictionnary.Objects.Packets.Client;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pictionnary
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

            /*
            TCPClient.ServerIP = "172.16.30.81";
            TCPClient.ServerPort = 32323;
            if(TCPClient.SendPacket(new ClientRegisterPacket(server)) == null)
            {
                Console.WriteLine("OUPS");
            }*/

            
            if (server != null)
            {
                TCPClient.ServerIP = server.ServerIP;
                TCPClient.ServerPort = server.ServerPort;
            }
            else
            {
                TCPClient.ServerIP = Console.ReadLine();
                TCPClient.ServerPort = 32323;
            }

            while (true)
            {

                if (TCPClient.SendPacket(new ClientPingPacket()) == null)
                {
                    Console.WriteLine("Serveur indisponible");
                }
                else
                {
                    Console.WriteLine("Serveur disponible");
                }

                Console.ReadKey(); 
            }

            /*
            TCPClient.SendPacket(new ClientSendPointsPacket(new List<Point>()));
            */


            //Console.ReadKey();
        }
    }
}
