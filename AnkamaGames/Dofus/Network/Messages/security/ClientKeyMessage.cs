


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ClientKeyMessage : Dofus2Message
{

public const uint Id = 9962;
public override uint MessageId
{
    get { return Id; }
}

public string key;
        

public ClientKeyMessage()
{
}

public ClientKeyMessage(string key)
        {
            this.key = key;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(key);
            

}

public override void Deserialize(IDataReader reader)
{

key = reader.ReadUTF();
            

}


}


}