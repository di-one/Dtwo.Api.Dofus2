


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChatAbstractServerMessage : Dofus2Message
{

public const uint Id = 4957;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public string content;
        public int timestamp;
        public string fingerprint;
        

public ChatAbstractServerMessage()
{
}

public ChatAbstractServerMessage(sbyte channel, string content, int timestamp, string fingerprint)
        {
            this.channel = channel;
            this.content = content;
            this.timestamp = timestamp;
            this.fingerprint = fingerprint;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(channel);
            writer.WriteUTF(content);
            writer.WriteInt(timestamp);
            writer.WriteUTF(fingerprint);
            

}

public override void Deserialize(IDataReader reader)
{

channel = reader.ReadSbyte();
            content = reader.ReadUTF();
            timestamp = reader.ReadInt();
            fingerprint = reader.ReadUTF();
            

}


}


}