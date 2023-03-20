


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SpellForPreset
{

public const short Id = 6944;
public virtual short TypeId
{
    get { return Id; }
}

public uint spellId;
        public short[] shortcuts;
        

public SpellForPreset()
{
}

public SpellForPreset(uint spellId, short[] shortcuts)
        {
            this.spellId = spellId;
            this.shortcuts = shortcuts;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteShort((short)shortcuts.Length);
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            shortcuts = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 shortcuts[i] = reader.ReadShort();
            }
            

}


}


}