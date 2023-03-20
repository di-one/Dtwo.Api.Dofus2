


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SocialNoticeMessage : Dofus2Message
{

public const uint Id = 3981;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        public int timestamp;
        public double memberId;
        public string memberName;
        

public SocialNoticeMessage()
{
}

public SocialNoticeMessage(string content, int timestamp, double memberId, string memberName)
        {
            this.content = content;
            this.timestamp = timestamp;
            this.memberId = memberId;
            this.memberName = memberName;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteVarLong(memberId);
            writer.WriteUTF(memberName);
            

}

public override void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            memberId = reader.ReadVarUhLong();
            memberName = reader.ReadUTF();
            

}


}


}