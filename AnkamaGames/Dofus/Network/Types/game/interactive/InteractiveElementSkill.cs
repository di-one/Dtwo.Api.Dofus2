


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class InteractiveElementSkill
{

public const short Id = 9259;
public virtual short TypeId
{
    get { return Id; }
}

public uint skillId;
        public int skillInstanceUid;
        

public InteractiveElementSkill()
{
}

public InteractiveElementSkill(uint skillId, int skillInstanceUid)
        {
            this.skillId = skillId;
            this.skillInstanceUid = skillInstanceUid;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteInt(skillInstanceUid);
            

}

public virtual void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            skillInstanceUid = reader.ReadInt();
            

}


}


}