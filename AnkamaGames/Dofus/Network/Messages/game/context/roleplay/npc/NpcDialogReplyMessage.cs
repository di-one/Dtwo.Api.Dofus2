


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NpcDialogReplyMessage : Dofus2Message
{

public const uint Id = 8790;
public override uint MessageId
{
    get { return Id; }
}

public uint replyId;
        

public NpcDialogReplyMessage()
{
}

public NpcDialogReplyMessage(uint replyId)
        {
            this.replyId = replyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)replyId);
            

}

public override void Deserialize(IDataReader reader)
{

replyId = reader.ReadVarUhInt();
            

}


}


}