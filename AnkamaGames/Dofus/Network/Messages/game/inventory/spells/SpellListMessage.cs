


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SpellListMessage : Dofus2Message
{

public const uint Id = 3146;
public override uint MessageId
{
    get { return Id; }
}

public bool spellPrevisualization;
        public Types.SpellItem[] spells;
        

public SpellListMessage()
{
}

public SpellListMessage(bool spellPrevisualization, Types.SpellItem[] spells)
        {
            this.spellPrevisualization = spellPrevisualization;
            this.spells = spells;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(spellPrevisualization);
            writer.WriteShort((short)spells.Length);
            foreach (var entry in spells)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

spellPrevisualization = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            spells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 spells[i] = new Types.SpellItem();
                 spells[i].Deserialize(reader);
            }
            

}


}


}