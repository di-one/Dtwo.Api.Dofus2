


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayDelayedActionFinishedMessage : Dofus2Message
{

public const uint Id = 5900;
public override uint MessageId
{
    get { return Id; }
}

public double delayedCharacterId;
        public sbyte delayTypeId;
        

public GameRolePlayDelayedActionFinishedMessage()
{
}

public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, sbyte delayTypeId)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(delayedCharacterId);
            writer.WriteSbyte(delayTypeId);
            

}

public override void Deserialize(IDataReader reader)
{

delayedCharacterId = reader.ReadDouble();
            delayTypeId = reader.ReadSbyte();
            

}


}


}