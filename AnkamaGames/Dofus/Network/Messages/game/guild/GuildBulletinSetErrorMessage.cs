


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildBulletinSetErrorMessage : SocialNoticeSetErrorMessage
{

public const uint Id = 1678;
public override uint MessageId
{
    get { return Id; }
}



public GuildBulletinSetErrorMessage()
{
}

public GuildBulletinSetErrorMessage(sbyte reason)
         : base(reason)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}