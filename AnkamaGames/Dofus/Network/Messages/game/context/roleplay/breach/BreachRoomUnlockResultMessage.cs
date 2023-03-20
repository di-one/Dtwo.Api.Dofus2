


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachRoomUnlockResultMessage : Dofus2Message
{

public const uint Id = 6865;
public override uint MessageId
{
    get { return Id; }
}

public sbyte roomId;
        public sbyte result;
        

public BreachRoomUnlockResultMessage()
{
}

public BreachRoomUnlockResultMessage(sbyte roomId, sbyte result)
        {
            this.roomId = roomId;
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(roomId);
            writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

roomId = reader.ReadSbyte();
            result = reader.ReadSbyte();
            

}


}


}