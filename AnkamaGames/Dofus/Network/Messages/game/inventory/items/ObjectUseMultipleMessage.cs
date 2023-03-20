


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectUseMultipleMessage : ObjectUseMessage
{

public const uint Id = 4566;
public override uint MessageId
{
    get { return Id; }
}

public uint quantity;
        

public ObjectUseMultipleMessage()
{
}

public ObjectUseMultipleMessage(uint quantity)
        {
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            quantity = reader.ReadVarUhInt();
            

}


}


}