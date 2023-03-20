


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
{

public const uint Id = 1091;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public short casterCellId;
        public short targetCellId;
        

public GameActionFightExchangePositionsMessage()
{
}

public GameActionFightExchangePositionsMessage(uint actionId, double sourceId, double targetId, short casterCellId, short targetCellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.casterCellId = casterCellId;
            this.targetCellId = targetCellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteShort(casterCellId);
            writer.WriteShort(targetCellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            casterCellId = reader.ReadShort();
            targetCellId = reader.ReadShort();
            

}


}


}