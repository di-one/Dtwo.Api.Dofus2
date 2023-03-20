


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ForgettableSpellItem : SpellItem
{

public const short Id = 650;
public override short TypeId
{
    get { return Id; }
}

public bool available;
        

public ForgettableSpellItem()
{
}

public ForgettableSpellItem(int spellId, short spellLevel, bool available)
         : base(spellId, spellLevel)
        {
            this.available = available;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(available);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            available = reader.ReadBoolean();
            

}


}


}