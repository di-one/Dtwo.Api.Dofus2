


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EmoteAddMessage : Dofus2Message
{

public const uint Id = 9636;
public override uint MessageId
{
    get { return Id; }
}

public ushort emoteId;
        

public EmoteAddMessage()
{
}

public EmoteAddMessage(ushort emoteId)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(emoteId);
            

}

public override void Deserialize(IDataReader reader)
{

emoteId = reader.ReadUShort();
            

}


}


}