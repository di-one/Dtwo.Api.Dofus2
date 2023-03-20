


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntLegendaryRequestMessage : Dofus2Message
{

public const uint Id = 9060;
public override uint MessageId
{
    get { return Id; }
}

public uint legendaryId;
        

public TreasureHuntLegendaryRequestMessage()
{
}

public TreasureHuntLegendaryRequestMessage(uint legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)legendaryId);
            

}

public override void Deserialize(IDataReader reader)
{

legendaryId = reader.ReadVarUhShort();
            

}


}


}