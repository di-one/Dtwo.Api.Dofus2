


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObtainedItemMessage : Dofus2Message
{

public const uint Id = 9033;
public override uint MessageId
{
    get { return Id; }
}

public uint genericId;
        public uint baseQuantity;
        

public ObtainedItemMessage()
{
}

public ObtainedItemMessage(uint genericId, uint baseQuantity)
        {
            this.genericId = genericId;
            this.baseQuantity = baseQuantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)genericId);
            writer.WriteVarInt((int)baseQuantity);
            

}

public override void Deserialize(IDataReader reader)
{

genericId = reader.ReadVarUhInt();
            baseQuantity = reader.ReadVarUhInt();
            

}


}


}