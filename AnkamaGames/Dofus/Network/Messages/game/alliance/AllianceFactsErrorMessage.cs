


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceFactsErrorMessage : Dofus2Message
{

public const uint Id = 9996;
public override uint MessageId
{
    get { return Id; }
}

public uint allianceId;
        

public AllianceFactsErrorMessage()
{
}

public AllianceFactsErrorMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)allianceId);
            

}

public override void Deserialize(IDataReader reader)
{

allianceId = reader.ReadVarUhInt();
            

}


}


}