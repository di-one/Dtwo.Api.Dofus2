


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectMovementMessage : Dofus2Message
{

public const uint Id = 5116;
public override uint MessageId
{
    get { return Id; }
}

public uint objectUID;
        public short position;
        

public ObjectMovementMessage()
{
}

public ObjectMovementMessage(uint objectUID, short position)
        {
            this.objectUID = objectUID;
            this.position = position;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectUID);
            writer.WriteShort(position);
            

}

public override void Deserialize(IDataReader reader)
{

objectUID = reader.ReadVarUhInt();
            position = reader.ReadShort();
            

}


}


}