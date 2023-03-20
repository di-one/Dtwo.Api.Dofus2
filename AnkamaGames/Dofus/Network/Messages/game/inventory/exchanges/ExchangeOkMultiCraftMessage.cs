


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeOkMultiCraftMessage : Dofus2Message
{

public const uint Id = 6446;
public override uint MessageId
{
    get { return Id; }
}

public double initiatorId;
        public double otherId;
        public sbyte role;
        

public ExchangeOkMultiCraftMessage()
{
}

public ExchangeOkMultiCraftMessage(double initiatorId, double otherId, sbyte role)
        {
            this.initiatorId = initiatorId;
            this.otherId = otherId;
            this.role = role;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(initiatorId);
            writer.WriteVarLong(otherId);
            writer.WriteSbyte(role);
            

}

public override void Deserialize(IDataReader reader)
{

initiatorId = reader.ReadVarUhLong();
            otherId = reader.ReadVarUhLong();
            role = reader.ReadSbyte();
            

}


}


}