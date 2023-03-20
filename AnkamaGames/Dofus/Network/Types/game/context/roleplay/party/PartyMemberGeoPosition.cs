


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PartyMemberGeoPosition
{

public const short Id = 1033;
public virtual short TypeId
{
    get { return Id; }
}

public int memberId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        

public PartyMemberGeoPosition()
{
}

public PartyMemberGeoPosition(int memberId, short worldX, short worldY, double mapId, uint subAreaId)
        {
            this.memberId = memberId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(memberId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            

}

public virtual void Deserialize(IDataReader reader)
{

memberId = reader.ReadInt();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            

}


}


}