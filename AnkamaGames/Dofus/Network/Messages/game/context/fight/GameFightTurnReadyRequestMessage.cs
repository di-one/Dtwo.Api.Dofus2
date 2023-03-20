


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightTurnReadyRequestMessage : Dofus2Message
{

public const uint Id = 4303;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnReadyRequestMessage()
{
}

public GameFightTurnReadyRequestMessage(double id)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            

}


}


}