


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AchievementAchieved
{

public const short Id = 3063;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public double achievedBy;
        

public AchievementAchieved()
{
}

public AchievementAchieved(uint id, double achievedBy)
        {
            this.id = id;
            this.achievedBy = achievedBy;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)id);
            writer.WriteVarLong(achievedBy);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhShort();
            achievedBy = reader.ReadVarUhLong();
            

}


}


}