


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateLifePointsMessage : Dofus2Message
{

public const uint Id = 6350;
public override uint MessageId
{
    get { return Id; }
}

public uint lifePoints;
        public uint maxLifePoints;
        

public UpdateLifePointsMessage()
{
}

public UpdateLifePointsMessage(uint lifePoints, uint maxLifePoints)
        {
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            

}

public override void Deserialize(IDataReader reader)
{

lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            

}


}


}