namespace Pictionnary.Networking.Objects.Packets.Client
{
    class ClientUnregisterPacket : Packet
    {
        TCPServer _client;

        public ClientUnregisterPacket(TCPServer client) : base(PacketType.CLIENTPACKETUNREGISTER)
        {
            _client = client;
        }

        internal TCPServer Client { get => _client; set => _client = value; }
    }
}
