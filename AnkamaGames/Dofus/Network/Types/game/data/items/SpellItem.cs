


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SpellItem : Item
{

public const short Id = 2784;
public override short TypeId
{
    get { return Id; }
}

public int spellId;
        public short spellLevel;
        

public SpellItem()
{
}

public SpellItem(int spellId, short spellLevel)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(spellId);
            writer.WriteShort(spellLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadInt();
            spellLevel = reader.ReadShort();
            

}


}


}