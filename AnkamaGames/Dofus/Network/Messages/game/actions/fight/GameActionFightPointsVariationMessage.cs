


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
{

public const uint Id = 6886;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short delta;
        

public GameActionFightPointsVariationMessage()
{
}

public GameActionFightPointsVariationMessage(uint actionId, double sourceId, double targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(delta);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            delta = reader.ReadShort();
            

}


}


}