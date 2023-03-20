


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PopupWarningMessage : Dofus2Message
{

public const uint Id = 4137;
public override uint MessageId
{
    get { return Id; }
}

public byte lockDuration;
        public string author;
        public string content;
        

public PopupWarningMessage()
{
}

public PopupWarningMessage(byte lockDuration, string author, string content)
        {
            this.lockDuration = lockDuration;
            this.author = author;
            this.content = content;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteByte(lockDuration);
            writer.WriteUTF(author);
            writer.WriteUTF(content);
            

}

public override void Deserialize(IDataReader reader)
{

lockDuration = reader.ReadByte();
            author = reader.ReadUTF();
            content = reader.ReadUTF();
            

}


}


}