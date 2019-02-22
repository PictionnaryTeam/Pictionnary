namespace Pictionnary.Networking.Objects.Packets
{
    enum PacketType
    {
        CLIENTPACKETPING,                                      //PING PACKETS
        SERVERPACKETCONFIRMATION,                              //OK or KO
        CLIENTPACKETPOINTS,                                    //Draw points
        CLIENTREGISTER,                                        //Register to the room master
        CLIENTPACKETSENDROOM,
        CLIENTPACKETREQUESTROOM, SERVERPACKETSENDROOM,
        CLIENTPACKETUNREGISTER,
        CLIENTPACKETSENDCHATMESSAGEEVENT
    }
}
