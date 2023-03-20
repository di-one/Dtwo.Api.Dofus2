


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeOnHumanVendorRequestMessage : Dofus2Message
{

public const uint Id = 5497;
public override uint MessageId
{
    get { return Id; }
}

public double humanVendorId;
        public uint humanVendorCell;
        

public ExchangeOnHumanVendorRequestMessage()
{
}

public ExchangeOnHumanVendorRequestMessage(double humanVendorId, uint humanVendorCell)
        {
            this.humanVendorId = humanVendorId;
            this.humanVendorCell = humanVendorCell;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(humanVendorId);
            writer.WriteVarShort((int)humanVendorCell);
            

}

public override void Deserialize(IDataReader reader)
{

humanVendorId = reader.ReadVarUhLong();
            humanVendorCell = reader.ReadVarUhShort();
            

}


}


}