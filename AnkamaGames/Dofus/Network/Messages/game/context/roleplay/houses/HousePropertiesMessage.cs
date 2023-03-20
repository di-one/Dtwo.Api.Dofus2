


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HousePropertiesMessage : Dofus2Message
{

public const uint Id = 4311;
public override uint MessageId
{
    get { return Id; }
}

public uint houseId;
        public int[] doorsOnMap;
        public Types.HouseInstanceInformations properties;
        

public HousePropertiesMessage()
{
}

public HousePropertiesMessage(uint houseId, int[] doorsOnMap, Types.HouseInstanceInformations properties)
        {
            this.houseId = houseId;
            this.doorsOnMap = doorsOnMap;
            this.properties = properties;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteShort((short)doorsOnMap.Length);
            foreach (var entry in doorsOnMap)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadUShort();
            doorsOnMap = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 doorsOnMap[i] = reader.ReadInt();
            }
            properties = ProtocolTypeManager.GetInstance<Types.HouseInstanceInformations>(reader.ReadUShort());
            properties.Deserialize(reader);
            

}


}


}