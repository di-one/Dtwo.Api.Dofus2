


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartedWithStorageMessage : ExchangeStartedMessage
{

public const uint Id = 758;
public override uint MessageId
{
    get { return Id; }
}

public uint storageMaxSlot;
        

public ExchangeStartedWithStorageMessage()
{
}

public ExchangeStartedWithStorageMessage(sbyte exchangeType, uint storageMaxSlot)
         : base(exchangeType)
        {
            this.storageMaxSlot = storageMaxSlot;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)storageMaxSlot);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            storageMaxSlot = reader.ReadVarUhInt();
            

}


}


}