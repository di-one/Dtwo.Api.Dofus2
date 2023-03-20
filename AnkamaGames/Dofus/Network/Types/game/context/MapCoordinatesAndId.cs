


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class MapCoordinatesAndId : MapCoordinates
{

public const short Id = 9300;
public override short TypeId
{
    get { return Id; }
}

public double mapId;
        

public MapCoordinatesAndId()
{
}

public MapCoordinatesAndId(short worldX, short worldY, double mapId)
         : base(worldX, worldY)
        {
            this.mapId = mapId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(mapId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            mapId = reader.ReadDouble();
            

}


}


}