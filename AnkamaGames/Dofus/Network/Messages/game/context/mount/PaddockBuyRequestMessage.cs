


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockBuyRequestMessage : Dofus2Message
{

public const uint Id = 960;
public override uint MessageId
{
    get { return Id; }
}

public double proposedPrice;
        

public PaddockBuyRequestMessage()
{
}

public PaddockBuyRequestMessage(double proposedPrice)
        {
            this.proposedPrice = proposedPrice;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(proposedPrice);
            

}

public override void Deserialize(IDataReader reader)
{

proposedPrice = reader.ReadVarUhLong();
            

}


}


}