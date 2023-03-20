


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
{

public const uint Id = 1184;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public uint elementId;
        

public LockableStateUpdateStorageMessage()
{
}

public LockableStateUpdateStorageMessage(bool locked, double mapId, uint elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(mapId);
            writer.WriteVarInt((int)elementId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadDouble();
            elementId = reader.ReadVarUhInt();
            

}


}


}