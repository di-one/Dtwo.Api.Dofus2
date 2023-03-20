


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatServerCopyMessage : ChatAbstractServerMessage
{

public const uint Id = 9262;
public override uint MessageId
{
    get { return Id; }
}

public double receiverId;
        public string receiverName;
        

public ChatServerCopyMessage()
{
}

public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName)
         : base(channel, content, timestamp, fingerprint)
        {
            this.receiverId = receiverId;
            this.receiverName = receiverName;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(receiverId);
            writer.WriteUTF(receiverName);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            receiverId = reader.ReadVarUhLong();
            receiverName = reader.ReadUTF();
            

}


}


}