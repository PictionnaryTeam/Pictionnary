using Pictionnary.GameClasses;
using Pictionnary.Networking.Helpers;
using Pictionnary.Networking.Objects.Packets;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Pictionnary.Networking.Objects;

namespace Pictionnary.Networking
{
    /// <summary>
    /// Represent a TCP server
    /// </summary>
    class TCPServer
    {
        //Server informations
        String serverIP;
        IPAddress serverAdress;
        int serverPort;

        //Main TCP Listener
        TcpListener tcpListener;

        //Pending stop request
        bool stopPending = false;

        //Keep threads list for threads closing
        List<Thread> threadsList = new List<Thread>();

        //Actual room
        Room room;

        //Public
        public string ServerIP { get => serverIP; set => serverIP = value; }
        public IPAddress ServerAdress { get => serverAdress; set => serverAdress = value; }
        public int ServerPort { get => serverPort; set => serverPort = value; }
        internal Room Room { get => room; set => room = value; }


        /// <summary>
        /// Create a new instance of the <see cref="TCPServer"/> class
        /// </summary>
        /// <param name="serverIP">Ip or 'localhost'</param>
        /// <param name="serverPort"></param>
        public TCPServer(String serverIP, int serverPort)
        {
            //Set room
            room = null;

            //If local mode
            if (serverIP == "localhost")
            {
                //Get local ip
                serverIP = NetworkHelper.GetLocalAdress();
            }

            //Set values
            this.serverIP = serverIP;
            this.serverPort = serverPort;
        }


        /// <summary>
        /// Start TCP Server
        /// </summary>
        public void Start()
        {
            //Parse server ip
            serverAdress = IPAddress.Parse(serverIP);

            //Start server
            ConsoleHelper.Write($"Launching server on endpoint {serverIP}:{serverPort}");
            StartListening();

            //Create new thread and assign start point
            ConsoleHelper.Write("Starting connection accepting thread ...");
            ThreadStart startPoint = new ThreadStart(AcceptConnection);
            Thread connectionAcceptingThread = new Thread(startPoint);
            connectionAcceptingThread.Start();
            ConsoleHelper.Write("Connection accepting thread started ...");
            ConsoleHelper.Write("Waiting for packets ...");
        }


        /// <summary>
        /// Stop TCP Server
        /// </summary>
        public void Stop()
        {
            //Request stop
            stopPending = true;
        }


        /// <summary>
        /// Start listening to queries
        /// </summary>
        public void StartListening()
        {
            //init new TCP listener
            tcpListener = new TcpListener(serverAdress, serverPort);

            //start
            tcpListener.Start();
        }


        /// <summary>
        /// Accept connections from TCP Client
        /// </summary>
        public void AcceptConnection()
        {
            //Until we request stop
            while (!stopPending)
            {
                //Wait for new packet
                Socket socket = tcpListener.AcceptSocket();

                //Create new thread and assign start point
                ThreadStart startPoint = new ThreadStart(() => AcceptPacket(socket));
                Thread newThread = new Thread(startPoint);

                //Add thread to list
                threadsList.Add(newThread);

                //Start thread
                ConsoleHelper.Write("Preparing for opening new thread (" + newThread.ManagedThreadId + ") ... ");
                newThread.Start();
                ConsoleHelper.Write("Thread " + newThread.ManagedThreadId + " opened !");
            }

            //Begin threads closing
            ConsoleHelper.Write("Waiting for threads to finish ...");

            //Just wait for threads closing
            while (threadsList.Count > 0) ;

            //End of threads closing
            ConsoleHelper.Write("Threads closing endend");

            //No longer accept comnnections
            ConsoleHelper.Write("Preparing for closing connection accepting thread ...");
            Thread.CurrentThread.Abort();
        }


        public TCPServerInfos ToServerInfos()
        {
            return new TCPServerInfos(serverIP, serverPort, room);
        }


        /// <summary>
        /// Accept packet from client
        /// </summary>
        /// <param name="socket"></param>
        public void AcceptPacket(Socket socket)
        {
            byte[] receiveBuffer = new byte[20480];

            //receive data
            int k = 0;
            try
            {
                k = socket.Receive(receiveBuffer);

                ConsoleHelper.Write("Thread " + Thread.CurrentThread.ManagedThreadId + " > Accept packet");
            }
            catch (Exception ex)
            {
                //Error
                ConsoleHelper.WriteError("Thread " + Thread.CurrentThread.ManagedThreadId + " > Error : " + ex.Message);

                //Abort
                ConsoleHelper.Write("Thread " + Thread.CurrentThread.ManagedThreadId + " > Preparing for thread aborting");
                socket.Close();
                threadsList.Remove(Thread.CurrentThread);
            }

            //create a table with correct size ^^ 
            byte[] receiveBufferComplete = new byte[k];
            for (int i = 0; i < k; i++)
                receiveBufferComplete[i] = receiveBuffer[i];

            //decode received date
            String receivedData = Encoding.UTF8.GetString(receiveBufferComplete);

            Packet receivedPacket = NetworkHelper.DeserializePacket(receiveBufferComplete);

            //get renturn packet
            Packet returnPacket = Program.packetManager.HandleReceivedPacket(receivedPacket);

            //encode packet and send
            try
            {
                ConsoleHelper.Write("Thread " + Thread.CurrentThread.ManagedThreadId + " > Preparing to send return packet");
                socket.Send(NetworkHelper.SerializePacket(returnPacket));
                ConsoleHelper.Write("Thread " + Thread.CurrentThread.ManagedThreadId + " > Return packet send !");
            }
            catch (Exception ex)
            {
                //Error
                ConsoleHelper.WriteError("Thread " + Thread.CurrentThread.ManagedThreadId + " > Error : " + ex.Message);
            }


            //close socket and accept new connection
            ConsoleHelper.Write("Thread " + Thread.CurrentThread.ManagedThreadId + " > Preparing for thread aborting");
            socket.Close();
            threadsList.Remove(Thread.CurrentThread);
            Thread.CurrentThread.Abort();
        }
    }
}
