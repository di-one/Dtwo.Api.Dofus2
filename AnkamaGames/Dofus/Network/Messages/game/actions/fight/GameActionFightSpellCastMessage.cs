


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
{

public const uint Id = 8511;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public short spellLevel;
        public short[] portalsIds;
        

public GameActionFightSpellCastMessage()
{
}

public GameActionFightSpellCastMessage(uint actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, uint spellId, short spellLevel, short[] portalsIds)
         : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.portalsIds = portalsIds;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort((short)portalsIds.Length);
            foreach (var entry in portalsIds)
            {
                 writer.WriteShort(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
            var limit = (ushort)reader.ReadUShort();
            portalsIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 portalsIds[i] = reader.ReadShort();
            }
            

}


}


}