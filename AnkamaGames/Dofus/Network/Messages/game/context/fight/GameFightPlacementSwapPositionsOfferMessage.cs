


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightPlacementSwapPositionsOfferMessage : Dofus2Message
{

public const uint Id = 81;
public override uint MessageId
{
    get { return Id; }
}

public int requestId;
        public double requesterId;
        public uint requesterCellId;
        public double requestedId;
        public uint requestedCellId;
        

public GameFightPlacementSwapPositionsOfferMessage()
{
}

public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, uint requesterCellId, double requestedId, uint requestedCellId)
        {
            this.requestId = requestId;
            this.requesterId = requesterId;
            this.requesterCellId = requesterCellId;
            this.requestedId = requestedId;
            this.requestedCellId = requestedCellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(requestId);
            writer.WriteDouble(requesterId);
            writer.WriteVarShort((int)requesterCellId);
            writer.WriteDouble(requestedId);
            writer.WriteVarShort((int)requestedCellId);
            

}

public override void Deserialize(IDataReader reader)
{

requestId = reader.ReadInt();
            requesterId = reader.ReadDouble();
            requesterCellId = reader.ReadVarUhShort();
            requestedId = reader.ReadDouble();
            requestedCellId = reader.ReadVarUhShort();
            

}


}


}