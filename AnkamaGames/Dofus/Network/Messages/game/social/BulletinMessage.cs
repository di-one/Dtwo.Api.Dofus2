


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BulletinMessage : SocialNoticeMessage
{

public const uint Id = 3789;
public override uint MessageId
{
    get { return Id; }
}

public int lastNotifiedTimestamp;
        

public BulletinMessage()
{
}

public BulletinMessage(string content, int timestamp, double memberId, string memberName, int lastNotifiedTimestamp)
         : base(content, timestamp, memberId, memberName)
        {
            this.lastNotifiedTimestamp = lastNotifiedTimestamp;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(lastNotifiedTimestamp);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lastNotifiedTimestamp = reader.ReadInt();
            

}


}


}