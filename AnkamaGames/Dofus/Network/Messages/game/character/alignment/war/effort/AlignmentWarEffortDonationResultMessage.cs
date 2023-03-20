


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlignmentWarEffortDonationResultMessage : Dofus2Message
{

public const uint Id = 3978;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public AlignmentWarEffortDonationResultMessage()
{
}

public AlignmentWarEffortDonationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}