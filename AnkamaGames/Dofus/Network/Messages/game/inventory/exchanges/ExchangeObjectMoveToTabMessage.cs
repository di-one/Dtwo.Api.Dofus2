


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeObjectMoveToTabMessage : Dofus2Message
{

public const uint Id = 7034;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public int quantity;
        public uint tabNumber;
        

public ExchangeObjectMoveToTabMessage()
{
}

public ExchangeObjectMoveToTabMessage(uint objectUID, int quantity, uint tabNumber)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.tabNumber = tabNumber;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteVarInt((int)tabNumber);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarInt();
            tabNumber = reader.ReadVarUhInt();
            

}


}


}