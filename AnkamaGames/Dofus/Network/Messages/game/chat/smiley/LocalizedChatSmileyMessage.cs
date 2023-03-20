


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LocalizedChatSmileyMessage : ChatSmileyMessage
{

public const uint Id = 1117;
public override uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public LocalizedChatSmileyMessage()
{
}

public LocalizedChatSmileyMessage(double entityId, uint smileyId, int accountId, uint cellId)
         : base(entityId, smileyId, accountId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            cellId = reader.ReadVarUhShort();
            

}


}


}