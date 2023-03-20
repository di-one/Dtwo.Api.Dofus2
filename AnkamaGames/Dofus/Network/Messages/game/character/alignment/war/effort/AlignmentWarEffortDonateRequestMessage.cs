


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlignmentWarEffortDonateRequestMessage : Dofus2Message
{

public const uint Id = 742;
public override uint MessageId
{
    get { return Id; }
}

public double donation;
        

public AlignmentWarEffortDonateRequestMessage()
{
}

public AlignmentWarEffortDonateRequestMessage(double donation)
        {
            this.donation = donation;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(donation);
            

}

public override void Deserialize(IDataReader reader)
{

donation = reader.ReadVarUhLong();
            

}


}


}