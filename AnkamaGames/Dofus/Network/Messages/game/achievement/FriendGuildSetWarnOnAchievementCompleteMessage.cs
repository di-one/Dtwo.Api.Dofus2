


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FriendGuildSetWarnOnAchievementCompleteMessage : Dofus2Message
{

public const uint Id = 9477;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendGuildSetWarnOnAchievementCompleteMessage()
{
}

public FriendGuildSetWarnOnAchievementCompleteMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}