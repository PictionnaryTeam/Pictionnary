using System;

namespace Pictionnary.Networking.Objects.Packets.Client
{
    [Serializable]
    class ClientUnregisterPacket : Packet
    {
        TCPServerInfos _client;

        public ClientUnregisterPacket(TCPServerInfos client) : base(PacketType.CLIENTPACKETUNREGISTER)
        {
            _client = client;
        }

        internal TCPServerInfos Client { get => _client; set => _client = value; }
    }
}
