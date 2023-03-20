


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CheckFileRequestMessage : Dofus2Message
{

public const uint Id = 8761;
public override uint MessageId
{
    get { return Id; }
}

public string filename;
        public sbyte type;
        

public CheckFileRequestMessage()
{
}

public CheckFileRequestMessage(string filename, sbyte type)
        {
            this.filename = filename;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(filename);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

filename = reader.ReadUTF();
            type = reader.ReadSbyte();
            

}


}


}