


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
{

public const short Id = 9686;
public override short TypeId
{
    get { return Id; }
}

public uint grade;
        

public CharacterMinimalPlusLookAndGradeInformations()
{
}

public CharacterMinimalPlusLookAndGradeInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, uint grade)
         : base(id, name, level, entityLook, breed)
        {
            this.grade = grade;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)grade);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            grade = reader.ReadVarUhInt();
            

}


}


}