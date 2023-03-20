


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicWhoAmIRequestMessage : Dofus2Message
{

public const uint Id = 4263;
public override uint MessageId
{
    get { return Id; }
}

public bool verbose;
        

public BasicWhoAmIRequestMessage()
{
}

public BasicWhoAmIRequestMessage(bool verbose)
        {
            this.verbose = verbose;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(verbose);
            

}

public override void Deserialize(IDataReader reader)
{

verbose = reader.ReadBoolean();
            

}


}


}