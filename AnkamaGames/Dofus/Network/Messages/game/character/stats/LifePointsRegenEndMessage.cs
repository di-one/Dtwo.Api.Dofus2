


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LifePointsRegenEndMessage : UpdateLifePointsMessage
{

public const uint Id = 6929;
public override uint MessageId
{
    get { return Id; }
}

public uint lifePointsGained;
        

public LifePointsRegenEndMessage()
{
}

public LifePointsRegenEndMessage(uint lifePoints, uint maxLifePoints, uint lifePointsGained)
         : base(lifePoints, maxLifePoints)
        {
            this.lifePointsGained = lifePointsGained;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)lifePointsGained);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            lifePointsGained = reader.ReadVarUhInt();
            

}


}


}