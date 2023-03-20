


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatSmileyRequestMessage : Dofus2Message
{

public const uint Id = 5949;
public override uint MessageId
{
    get { return Id; }
}

public uint smileyId;
        

public ChatSmileyRequestMessage()
{
}

public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

smileyId = reader.ReadVarUhShort();
            

}


}


}