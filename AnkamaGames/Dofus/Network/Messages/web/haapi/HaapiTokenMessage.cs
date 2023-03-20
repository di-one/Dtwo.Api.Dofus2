


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiTokenMessage : Dofus2Message
{

public const uint Id = 6142;
public override uint MessageId
{
    get { return Id; }
}

public string token;
        

public HaapiTokenMessage()
{
}

public HaapiTokenMessage(string token)
        {
            this.token = token;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(token);
            

}

public override void Deserialize(IDataReader reader)
{

token = reader.ReadUTF();
            

}


}


}