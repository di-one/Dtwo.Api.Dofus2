


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterBaseInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 3972;
public override short TypeId
{
    get { return Id; }
}

public bool sex;
        

public CharacterBaseInformations()
{
}

public CharacterBaseInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex)
         : base(id, name, level, entityLook, breed)
        {
            this.sex = sex;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(sex);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            sex = reader.ReadBoolean();
            

}


}


}