


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ConsoleMessage : Dofus2Message
{

public const uint Id = 6197;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public string content;
        

public ConsoleMessage()
{
}

public ConsoleMessage(sbyte type, string content)
        {
            this.type = type;
            this.content = content;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteUTF(content);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            content = reader.ReadUTF();
            

}


}


}