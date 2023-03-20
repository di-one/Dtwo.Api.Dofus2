


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementFinishedMessage : Dofus2Message
{

public const uint Id = 6042;
public override uint MessageId
{
    get { return Id; }
}

public Types.AchievementAchievedRewardable achievement;
        

public AchievementFinishedMessage()
{
}

public AchievementFinishedMessage(Types.AchievementAchievedRewardable achievement)
        {
            this.achievement = achievement;
        }
        

public override void Serialize(IDataWriter writer)
{

achievement.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

achievement = new Types.AchievementAchievedRewardable();
            achievement.Deserialize(reader);
            

}


}


}