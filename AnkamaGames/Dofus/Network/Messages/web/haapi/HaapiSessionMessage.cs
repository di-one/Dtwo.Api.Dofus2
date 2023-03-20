


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiSessionMessage : Dofus2Message
{

public const uint Id = 4089;
public override uint MessageId
{
    get { return Id; }
}

public string key;
        public sbyte type;
        

public HaapiSessionMessage()
{
}

public HaapiSessionMessage(string key, sbyte type)
        {
            this.key = key;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(key);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

key = reader.ReadUTF();
            type = reader.ReadSbyte();
            

}


}


}