


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChangeHavenBagRoomRequestMessage : Dofus2Message
{

public const uint Id = 9860;
public override uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        

public ChangeHavenBagRoomRequestMessage()
{
}

public ChangeHavenBagRoomRequestMessage(sbyte roomId)
        {
            this.roomId = roomId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            

}

public override void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            

}


}


}