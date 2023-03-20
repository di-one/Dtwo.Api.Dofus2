


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TaxCollectorBasicInformations
{

public const short Id = 8484;
public virtual short TypeId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        

public TaxCollectorBasicInformations()
{
}

public TaxCollectorBasicInformations(uint firstNameId, uint lastNameId, short worldX, short worldY, double mapId, uint subAreaId)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            

}

public virtual void Deserialize(IDataReader reader)
{

firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            

}


}


}