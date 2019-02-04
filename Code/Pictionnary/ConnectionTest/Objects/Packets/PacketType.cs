namespace ConnectionTest.Objects.Packets
{
    enum PacketType
    {
        CLIENTPACKETPING, SERVERPACKETPING,                    //PING PACKETS
        SERVERPACKETCONFIRMATION,                              //OK or KO
        CLIENTPACKETPOINTS,                                    //Draw points
        CLIENTREGISTER                                         //Register to the room master
    }
}
