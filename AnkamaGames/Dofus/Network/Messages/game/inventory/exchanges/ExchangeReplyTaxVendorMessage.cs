


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeReplyTaxVendorMessage : Dofus2Message
{

public const uint Id = 1144;
public override uint MessageId
{
    get { return Id; }
}

public double objectValue;
        public double totalTaxValue;
        

public ExchangeReplyTaxVendorMessage()
{
}

public ExchangeReplyTaxVendorMessage(double objectValue, double totalTaxValue)
        {
            this.objectValue = objectValue;
            this.totalTaxValue = totalTaxValue;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(objectValue);
            writer.WriteVarLong(totalTaxValue);
            

}

public override void Deserialize(IDataReader reader)
{

objectValue = reader.ReadVarUhLong();
            totalTaxValue = reader.ReadVarUhLong();
            

}


}


}