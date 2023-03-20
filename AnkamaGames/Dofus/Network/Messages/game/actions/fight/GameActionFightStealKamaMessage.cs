


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightStealKamaMessage : AbstractGameActionMessage
{

public const uint Id = 7363;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public double amount;
        

public GameActionFightStealKamaMessage()
{
}

public GameActionFightStealKamaMessage(uint actionId, double sourceId, double targetId, double amount)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.amount = amount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarLong(amount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            amount = reader.ReadVarUhLong();
            

}


}


}