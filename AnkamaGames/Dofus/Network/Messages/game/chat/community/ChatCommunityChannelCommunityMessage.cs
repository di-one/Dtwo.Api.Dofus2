


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatCommunityChannelCommunityMessage : Dofus2Message
{

public const uint Id = 9161;
public override uint MessageId
{
    get { return Id; }
}

public short communityId;
        

public ChatCommunityChannelCommunityMessage()
{
}

public ChatCommunityChannelCommunityMessage(short communityId)
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