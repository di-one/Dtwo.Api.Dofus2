


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class JobDescription
{

public const short Id = 6046;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte jobId;
        public Types.SkillActionDescription[] skills;
        

public JobDescription()
{
}

public JobDescription(sbyte jobId, Types.SkillActionDescription[] skills)
        {
            this.jobId = jobId;
            this.skills = skills;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(jobId);
            writer.WriteShort((short)skills.Length);
            foreach (var entry in skills)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

jobId = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            skills = new Types.SkillActionDescription[limit];
            for (int i = 0; i < limit; i++)
            {
                 skills[i] = ProtocolTypeManager.GetInstance<Types.SkillActionDescription>(reader.ReadUShort());
                 skills[i].Deserialize(reader);
            }
            

}


}


}