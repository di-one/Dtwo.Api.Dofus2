


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightTurnEndMessage : Dofus2Message
{

public const uint Id = 3804;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        

public GameFightTurnEndMessage()
{
}

public GameFightTurnEndMessage(double id)
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