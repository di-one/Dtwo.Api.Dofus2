


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementDetailsRequestMessage : Dofus2Message
{

public const uint Id = 2445;
public override uint MessageId
{
    get { return Id; }
}

public uint achievementId;
        

public AchievementDetailsRequestMessage()
{
}

public AchievementDetailsRequestMessage(uint achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)achievementId);
            

}

public override void Deserialize(IDataReader reader)
{

achievementId = reader.ReadVarUhShort();
            

}


}


}