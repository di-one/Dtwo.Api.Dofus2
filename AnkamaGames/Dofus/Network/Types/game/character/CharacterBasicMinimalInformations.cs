


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterBasicMinimalInformations : AbstractCharacterInformation
{

public const short Id = 467;
public override short TypeId
{
    get { return Id; }
}

public string name;
        

public CharacterBasicMinimalInformations()
{
}

public CharacterBasicMinimalInformations(double id, string name)
         : base(id)
        {
            this.name = name;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            

}


}


}