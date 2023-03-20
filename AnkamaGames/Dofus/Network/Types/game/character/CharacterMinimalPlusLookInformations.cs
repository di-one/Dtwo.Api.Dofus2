


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
{

public const short Id = 5838;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook entityLook;
        public sbyte breed;
        

public CharacterMinimalPlusLookInformations()
{
}

public CharacterMinimalPlusLookInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed)
         : base(id, name, level)
        {
            this.entityLook = entityLook;
            this.breed = breed;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            entityLook.Serialize(writer);
            writer.WriteSbyte(breed);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            breed = reader.ReadSbyte();
            

}


}


}