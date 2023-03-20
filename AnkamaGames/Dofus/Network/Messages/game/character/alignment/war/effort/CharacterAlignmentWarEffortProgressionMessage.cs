


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterAlignmentWarEffortProgressionMessage : Dofus2Message
{

public const uint Id = 7285;
public override uint MessageId
{
    get { return Id; }
}

public double alignmentWarEffortDailyLimit;
        public double alignmentWarEffortDailyDonation;
        public double alignmentWarEffortPersonalDonation;
        

public CharacterAlignmentWarEffortProgressionMessage()
{
}

public CharacterAlignmentWarEffortProgressionMessage(double alignmentWarEffortDailyLimit, double alignmentWarEffortDailyDonation, double alignmentWarEffortPersonalDonation)
        {
            this.alignmentWarEffortDailyLimit = alignmentWarEffortDailyLimit;
            this.alignmentWarEffortDailyDonation = alignmentWarEffortDailyDonation;
            this.alignmentWarEffortPersonalDonation = alignmentWarEffortPersonalDonation;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(alignmentWarEffortDailyLimit);
            writer.WriteVarLong(alignmentWarEffortDailyDonation);
            writer.WriteVarLong(alignmentWarEffortPersonalDonation);
            

}

public override void Deserialize(IDataReader reader)
{

alignmentWarEffortDailyLimit = reader.ReadVarUhLong();
            alignmentWarEffortDailyDonation = reader.ReadVarUhLong();
            alignmentWarEffortPersonalDonation = reader.ReadVarUhLong();
            

}


}


}