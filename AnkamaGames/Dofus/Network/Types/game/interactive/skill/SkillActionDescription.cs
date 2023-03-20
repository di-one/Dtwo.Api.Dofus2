


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SkillActionDescription
{

public const short Id = 2029;
public virtual short TypeId
{
    get { return Id; }
}

public uint skillId;
        

public SkillActionDescription()
{
}

public SkillActionDescription(uint skillId)
        {
            this.skillId = skillId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)skillId);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhShort();
            

}


}


}