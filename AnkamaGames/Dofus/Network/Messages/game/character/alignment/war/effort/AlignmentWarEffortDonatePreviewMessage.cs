


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlignmentWarEffortDonatePreviewMessage : Dofus2Message
{

public const uint Id = 7512;
public override uint MessageId
{
    get { return Id; }
}

public double xp;
        

public AlignmentWarEffortDonatePreviewMessage()
{
}

public AlignmentWarEffortDonatePreviewMessage(double xp)
        {
            this.xp = xp;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(xp);
            

}

public override void Deserialize(IDataReader reader)
{

xp = reader.ReadDouble();
            

}


}


}