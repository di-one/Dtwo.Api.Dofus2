


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterSpellModification
{

public const short Id = 2905;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte modificationType;
        public uint spellId;
        public Types.CharacterCharacteristicDetailed value;
        

public CharacterSpellModification()
{
}

public CharacterSpellModification(sbyte modificationType, uint spellId, Types.CharacterCharacteristicDetailed value)
        {
            this.modificationType = modificationType;
            this.spellId = spellId;
            this.value = value;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(modificationType);
            writer.WriteVarShort((int)spellId);
            value.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

modificationType = reader.ReadSbyte();
            spellId = reader.ReadVarUhShort();
            value = new Types.CharacterCharacteristicDetailed();
            value.Deserialize(reader);
            

}


}


}