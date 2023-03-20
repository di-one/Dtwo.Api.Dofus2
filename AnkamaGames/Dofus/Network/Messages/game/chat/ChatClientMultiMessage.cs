


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatClientMultiMessage : ChatAbstractClientMessage
{

public const uint Id = 4757;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        

public ChatClientMultiMessage()
{
}

public ChatClientMultiMessage(string content, sbyte channel)
         : base(content)
        {
            this.channel = channel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(channel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            channel = reader.ReadSbyte();
            

}


}


}