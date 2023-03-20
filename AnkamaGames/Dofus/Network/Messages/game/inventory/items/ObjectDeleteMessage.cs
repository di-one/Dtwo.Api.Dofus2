


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectDeleteMessage : Dofus2Message
{

public const uint Id = 5494;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        

public ObjectDeleteMessage()
{
}

public ObjectDeleteMessage(uint objectUID, uint quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            

}


}


}