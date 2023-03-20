


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class MonsterInGroupInformations : MonsterInGroupLightInformations
{

public const short Id = 4170;
public override short TypeId
{
    get { return Id; }
}

public Types.EntityLook look;
        

public MonsterInGroupInformations()
{
}

public MonsterInGroupInformations(int genericId, sbyte grade, short level, Types.EntityLook look)
         : base(genericId, grade, level)
        {
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}