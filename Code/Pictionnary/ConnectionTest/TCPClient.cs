using ConnectionTest.Helpers;
using ConnectionTest.Objects.Packets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTest
{
    class TCPClient
    {
        String _serverIP;
        Int32 _serverPort;

        public TCPClient(String ip, Int32 port)
        {
            _serverIP = ip;
            _serverPort = port;
        }


        public Packet SendPacket(Packet packet)
        {
            try
            {
                //init new tcp client
                TcpClient tcpclnt = new TcpClient();

                //connect to the server
                tcpclnt.Connect(_serverIP, _serverPort);

                //get tcp stream
                Stream stm = tcpclnt.GetStream();

                //serilize packet to send
                byte[] packetBuffer = NetworkHelper.SerializePacket(packet);

                //write serialized packet
                stm.Write(packetBuffer, 0, packetBuffer.Length);

                //prepare for answer
                byte[] receiveBuffer = new byte[102400];
                int k = stm.Read(receiveBuffer, 0, 102400);

                //set the right size to received data
                byte[] receiveBufferComplete = new byte[k];
                for (int i = 0; i < k; i++)
                    receiveBufferComplete[i] = receiveBuffer[i];

                //deserialize answer
                Packet packetAnswer = NetworkHelper.DeserializePacket(receiveBufferComplete);

                //close connection
                tcpclnt.Close();

                return packetAnswer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
            return null;
        }

    }
}
