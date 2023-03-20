


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayDelayedActionMessage : Dofus2Message
{

public const uint Id = 1811;
public override uint MessageId
{
    get { return Id; }
}

public double delayedCharacterId;
        public sbyte delayTypeId;
        public double delayEndTime;
        

public GameRolePlayDelayedActionMessage()
{
}

public GameRolePlayDelayedActionMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime)
        {
            this.delayedCharacterId = delayedCharacterId;
            this.delayTypeId = delayTypeId;
            this.delayEndTime = delayEndTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(delayedCharacterId);
            writer.WriteSbyte(delayTypeId);
            writer.WriteDouble(delayEndTime);
            

}

public override void Deserialize(IDataReader reader)
{

delayedCharacterId = reader.ReadDouble();
            delayTypeId = reader.ReadSbyte();
            delayEndTime = reader.ReadDouble();
            

}


}


}