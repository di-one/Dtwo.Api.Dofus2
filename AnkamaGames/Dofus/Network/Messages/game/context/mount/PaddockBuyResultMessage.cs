


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockBuyResultMessage : Dofus2Message
{

public const uint Id = 7045;
public override uint MessageId
{
    get { return Id; }
}

public double paddockId;
        public bool bought;
        public double realPrice;
        

public PaddockBuyResultMessage()
{
}

public PaddockBuyResultMessage(double paddockId, bool bought, double realPrice)
        {
            this.paddockId = paddockId;
            this.bought = bought;
            this.realPrice = realPrice;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(paddockId);
            writer.WriteBoolean(bought);
            writer.WriteVarLong(realPrice);
            

}

public override void Deserialize(IDataReader reader)
{

paddockId = reader.ReadDouble();
            bought = reader.ReadBoolean();
            realPrice = reader.ReadVarUhLong();
            

}


}


}