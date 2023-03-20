


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementRewardErrorMessage : Dofus2Message
{

public const uint Id = 7498;
public override uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardErrorMessage()
{
}

public AchievementRewardErrorMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(achievementId);
            

}

public override void Deserialize(IDataReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}