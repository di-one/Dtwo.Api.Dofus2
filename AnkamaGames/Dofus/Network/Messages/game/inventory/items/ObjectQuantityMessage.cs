


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectQuantityMessage : Dofus2Message
{

public const uint Id = 5311;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public uint quantity;
        public sbyte origin;
        

public ObjectQuantityMessage()
{
}

public ObjectQuantityMessage(uint objectUID, uint quantity, sbyte origin)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.origin = origin;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            writer.WriteSbyte(origin);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
            origin = reader.ReadSbyte();
            

}


}


}