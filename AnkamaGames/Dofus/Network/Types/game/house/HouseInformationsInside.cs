


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HouseInformationsInside : HouseInformations
{

public const short Id = 5325;
public override short TypeId
{
    get { return Id; }
}

public Types.HouseInstanceInformations houseInfos;
        public short worldX;
        public short worldY;
        

public HouseInformationsInside()
{
}

public HouseInformationsInside(uint houseId, uint modelId, Types.HouseInstanceInformations houseInfos, short worldX, short worldY)
         : base(houseId, modelId)
        {
            this.houseInfos = houseInfos;
            this.worldX = worldX;
            this.worldY = worldY;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(houseInfos.TypeId);
            houseInfos.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            houseInfos = ProtocolTypeManager.GetInstance<Types.HouseInstanceInformations>(reader.ReadUShort());
            houseInfos.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            

}


}


}