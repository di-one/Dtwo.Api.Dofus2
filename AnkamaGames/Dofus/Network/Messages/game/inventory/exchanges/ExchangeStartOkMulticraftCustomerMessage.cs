


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkMulticraftCustomerMessage : Dofus2Message
{

public const uint Id = 3687;
public override uint MessageId
{
    get { return Id; }
}

public uint skillId;
        public byte crafterJobLevel;
        

public ExchangeStartOkMulticraftCustomerMessage()
{
}

public ExchangeStartOkMulticraftCustomerMessage(uint skillId, byte crafterJobLevel)
        {
            this.skillId = skillId;
            this.crafterJobLevel = crafterJobLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)skillId);
            writer.WriteByte(crafterJobLevel);
            

}

public override void Deserialize(IDataReader reader)
{

skillId = reader.ReadVarUhInt();
            crafterJobLevel = reader.ReadByte();
            

}


}


}