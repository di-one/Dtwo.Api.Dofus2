


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SkillActionDescriptionTimed : SkillActionDescription
{

public const short Id = 4372;
public override short TypeId
{
    get { return Id; }
}

public byte time;
        

public SkillActionDescriptionTimed()
{
}

public SkillActionDescriptionTimed(uint skillId, byte time)
         : base(skillId)
        {
            this.time = time;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(time);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            time = reader.ReadByte();
            

}


}


}