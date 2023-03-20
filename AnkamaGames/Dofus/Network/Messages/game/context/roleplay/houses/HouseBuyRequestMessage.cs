


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseBuyRequestMessage : Dofus2Message
{

public const uint Id = 3073;
public override uint MessageId
{
    get { return Id; }
}

public double proposedPrice;
        

public HouseBuyRequestMessage()
{
}

public HouseBuyRequestMessage(double proposedPrice)
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