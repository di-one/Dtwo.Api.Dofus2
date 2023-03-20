


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateMountCharacteristicsMessage : Dofus2Message
{

public const uint Id = 6180;
public override uint MessageId
{
    get { return Id; }
}

public int rideId;
        public Types.UpdateMountCharacteristic[] boostToUpdateList;
        

public UpdateMountCharacteristicsMessage()
{
}

public UpdateMountCharacteristicsMessage(int rideId, Types.UpdateMountCharacteristic[] boostToUpdateList)
        {
            this.rideId = rideId;
            this.boostToUpdateList = boostToUpdateList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rideId);
            writer.WriteShort((short)boostToUpdateList.Length);
            foreach (var entry in boostToUpdateList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

rideId = reader.ReadVarInt();
            var limit = (ushort)reader.ReadUShort();
            boostToUpdateList = new Types.UpdateMountCharacteristic[limit];
            for (int i = 0; i < limit; i++)
            {
                 boostToUpdateList[i] = ProtocolTypeManager.GetInstance<Types.UpdateMountCharacteristic>(reader.ReadUShort());
                 boostToUpdateList[i].Deserialize(reader);
            }
            

}


}


}