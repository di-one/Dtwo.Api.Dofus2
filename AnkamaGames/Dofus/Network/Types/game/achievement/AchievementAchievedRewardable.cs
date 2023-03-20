


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AchievementAchievedRewardable : AchievementAchieved
{

public const short Id = 2637;
public override short TypeId
{
    get { return Id; }
}

public uint finishedlevel;
        

public AchievementAchievedRewardable()
{
}

public AchievementAchievedRewardable(uint id, double achievedBy, uint finishedlevel)
         : base(id, achievedBy)
        {
            this.finishedlevel = finishedlevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)finishedlevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            finishedlevel = reader.ReadVarUhShort();
            

}


}


}