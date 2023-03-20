


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HouseSellRequestMessage : Dofus2Message
{

public const uint Id = 2707;
public override uint MessageId
{
    get { return Id; }
}

public int instanceId;
        public double amount;
        public bool forSale;
        

public HouseSellRequestMessage()
{
}

public HouseSellRequestMessage(int instanceId, double amount, bool forSale)
        {
            this.instanceId = instanceId;
            this.amount = amount;
            this.forSale = forSale;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(instanceId);
            writer.WriteVarLong(amount);
            writer.WriteBoolean(forSale);
            

}

public override void Deserialize(IDataReader reader)
{

instanceId = reader.ReadInt();
            amount = reader.ReadVarUhLong();
            forSale = reader.ReadBoolean();
            

}


}


}