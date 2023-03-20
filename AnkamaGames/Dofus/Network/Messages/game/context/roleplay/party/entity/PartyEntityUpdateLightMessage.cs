


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyEntityUpdateLightMessage : PartyUpdateLightMessage
{

public const uint Id = 985;
public override uint MessageId
{
    get { return Id; }
}

public sbyte indexId;
        

public PartyEntityUpdateLightMessage()
{
}

public PartyEntityUpdateLightMessage(uint partyId, double id, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, sbyte indexId)
         : base(partyId, id, lifePoints, maxLifePoints, prospecting, regenRate)
        {
            this.indexId = indexId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(indexId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            indexId = reader.ReadSbyte();
            

}


}


}