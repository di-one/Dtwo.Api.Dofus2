


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightPlacementPositionRequestMessage : Dofus2Message
{

public const uint Id = 4517;
public override uint MessageId
{
    get { return Id; }
}

public uint cellId;
        

public GameFightPlacementPositionRequestMessage()
{
}

public GameFightPlacementPositionRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            

}


}


}