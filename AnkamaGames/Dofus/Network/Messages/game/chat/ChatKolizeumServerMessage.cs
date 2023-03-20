


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatKolizeumServerMessage : ChatServerMessage
{

public const uint Id = 5686;
public override uint MessageId
{
    get { return Id; }
}

public short originServerId;
        

public ChatKolizeumServerMessage()
{
}

public ChatKolizeumServerMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, string prefix, int senderAccountId, short originServerId)
         : base(channel, content, timestamp, fingerprint, senderId, senderName, prefix, senderAccountId)
        {
            this.originServerId = originServerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(originServerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            originServerId = reader.ReadShort();
            

}


}


}