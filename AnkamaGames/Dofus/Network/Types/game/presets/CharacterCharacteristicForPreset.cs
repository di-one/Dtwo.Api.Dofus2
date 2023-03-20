


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterCharacteristicForPreset : SimpleCharacterCharacteristicForPreset
{

public const short Id = 8283;
public override short TypeId
{
    get { return Id; }
}

public int stuff;
        

public CharacterCharacteristicForPreset()
{
}

public CharacterCharacteristicForPreset(string keyword, int @base, int additionnal, int stuff)
         : base(keyword, @base, additionnal)
        {
            this.stuff = stuff;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)stuff);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            stuff = reader.ReadVarInt();
            

}


}


}