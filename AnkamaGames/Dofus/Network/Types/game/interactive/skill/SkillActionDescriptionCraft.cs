


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SkillActionDescriptionCraft : SkillActionDescription
{

public const short Id = 1139;
public override short TypeId
{
    get { return Id; }
}

public sbyte probability;
        

public SkillActionDescriptionCraft()
{
}

public SkillActionDescriptionCraft(uint skillId, sbyte probability)
         : base(skillId)
        {
            this.probability = probability;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(probability);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            probability = reader.ReadSbyte();
            

}


}


}