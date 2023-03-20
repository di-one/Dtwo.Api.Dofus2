


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ShortcutSpell : Shortcut
{

public const short Id = 8571;
public override short TypeId
{
    get { return Id; }
}

public uint spellId;
        

public ShortcutSpell()
{
}

public ShortcutSpell(sbyte slot, uint spellId)
         : base(slot)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            

}


}


}