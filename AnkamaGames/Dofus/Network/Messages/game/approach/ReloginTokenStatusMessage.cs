


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ReloginTokenStatusMessage : Dofus2Message
{

public const uint Id = 4736;
public override uint MessageId
{
    get { return Id; }
}

public bool validToken;
        public string token;
        

public ReloginTokenStatusMessage()
{
}

public ReloginTokenStatusMessage(bool validToken, string token)
        {
            this.validToken = validToken;
            this.token = token;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(validToken);
            writer.WriteUTF(token);
            

}

public override void Deserialize(IDataReader reader)
{

validToken = reader.ReadBoolean();
            token = reader.ReadUTF();
            

}


}


}