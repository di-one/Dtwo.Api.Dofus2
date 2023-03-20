


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicPongMessage : Dofus2Message
{

public const uint Id = 7692;
public override uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPongMessage()
{
}

public BasicPongMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public override void Deserialize(IDataReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}