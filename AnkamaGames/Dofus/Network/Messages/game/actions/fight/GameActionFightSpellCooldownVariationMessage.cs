


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
{

public const uint Id = 5388;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint spellId;
        public int value;
        

public GameActionFightSpellCooldownVariationMessage()
{
}

public GameActionFightSpellCooldownVariationMessage(uint actionId, double sourceId, double targetId, uint spellId, int value)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.spellId = spellId;
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)spellId);
            writer.WriteVarShort((int)value);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            spellId = reader.ReadVarUhShort();
            value = reader.ReadVarShort();
            

}


}


}