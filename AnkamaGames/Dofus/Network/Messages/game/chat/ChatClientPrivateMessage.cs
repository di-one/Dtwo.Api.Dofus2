


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatClientPrivateMessage : ChatAbstractClientMessage
{

public const uint Id = 398;
public override uint MessageId
{
    get { return Id; }
}

public Types.AbstractPlayerSearchInformation receiver;
        

public ChatClientPrivateMessage()
{
}

public ChatClientPrivateMessage(string content, Types.AbstractPlayerSearchInformation receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(receiver.TypeId);
            receiver.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            receiver = ProtocolTypeManager.GetInstance<Types.AbstractPlayerSearchInformation>(reader.ReadUShort());
            receiver.Deserialize(reader);
            

}


}


}