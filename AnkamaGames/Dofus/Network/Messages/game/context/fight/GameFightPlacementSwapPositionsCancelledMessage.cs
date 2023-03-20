


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightPlacementSwapPositionsCancelledMessage : Dofus2Message
{

public const uint Id = 7803;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        public double cancellerId;
        

public GameFightPlacementSwapPositionsCancelledMessage()
{
}

public GameFightPlacementSwapPositionsCancelledMessage(int requestId, double cancellerId)
        {
            this.requestId = requestId;
            this.cancellerId = cancellerId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteDouble(cancellerId);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            cancellerId = reader.ReadDouble();
            

}


}


}