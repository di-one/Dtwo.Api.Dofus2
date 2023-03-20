


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class MapCoordinatesExtended : MapCoordinatesAndId
{

public const short Id = 892;
public override short TypeId
{
    get { return Id; }
}

public uint subAreaId;
        

public MapCoordinatesExtended()
{
}

public MapCoordinatesExtended(short worldX, short worldY, double mapId, uint subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)subAreaId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            subAreaId = reader.ReadVarUhShort();
            

}


}


}