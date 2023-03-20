


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatCommunityChannelSetCommunityRequestMessage : Dofus2Message
{

public const uint Id = 8434;
public override uint MessageId
{
    get { return Id; }
}

public short communityId;
        

public ChatCommunityChannelSetCommunityRequestMessage()
{
}

public ChatCommunityChannelSetCommunityRequestMessage(short communityId)
        {
            this.communityId = communityId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(communityId);
            

}

public override void Deserialize(IDataReader reader)
{

communityId = reader.ReadShort();
            

}


}


}