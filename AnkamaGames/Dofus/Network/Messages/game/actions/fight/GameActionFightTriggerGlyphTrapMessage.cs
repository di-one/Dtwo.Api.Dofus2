


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
{

public const uint Id = 8387;
public override uint MessageId
{
    get { return Id; }
}

public short markId;
        public uint markImpactCell;
        public double triggeringCharacterId;
        public uint triggeredSpellId;
        

public GameActionFightTriggerGlyphTrapMessage()
{
}

public GameActionFightTriggerGlyphTrapMessage(uint actionId, double sourceId, short markId, uint markImpactCell, double triggeringCharacterId, uint triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.markImpactCell = markImpactCell;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteVarShort((int)markImpactCell);
            writer.WriteDouble(triggeringCharacterId);
            writer.WriteVarShort((int)triggeredSpellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            markId = reader.ReadShort();
            markImpactCell = reader.ReadVarUhShort();
            triggeringCharacterId = reader.ReadDouble();
            triggeredSpellId = reader.ReadVarUhShort();
            

}


}


}