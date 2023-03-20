


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CheckFileMessage : Dofus2Message
{

public const uint Id = 1064;
public override uint MessageId
{
    get { return Id; }
}

public string filenameHash;
        public sbyte type;
        public string value;
        

public CheckFileMessage()
{
}

public CheckFileMessage(string filenameHash, sbyte type, string value)
        {
            this.filenameHash = filenameHash;
            this.type = type;
            this.value = value;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(filenameHash);
            writer.WriteSbyte(type);
            writer.WriteUTF(value);
            

}

public override void Deserialize(IDataReader reader)
{

filenameHash = reader.ReadUTF();
            type = reader.ReadSbyte();
            value = reader.ReadUTF();
            

}


}


}