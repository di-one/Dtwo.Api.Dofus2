


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameActionMarkedCell
{

public const short Id = 1423;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public sbyte zoneSize;
        public int cellColor;
        public sbyte cellsType;
        

public GameActionMarkedCell()
{
}

public GameActionMarkedCell(uint cellId, sbyte zoneSize, int cellColor, sbyte cellsType)
        {
            this.cellId = cellId;
            this.zoneSize = zoneSize;
            this.cellColor = cellColor;
            this.cellsType = cellsType;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteSbyte(zoneSize);
            writer.WriteInt(cellColor);
            writer.WriteSbyte(cellsType);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            zoneSize = reader.ReadSbyte();
            cellColor = reader.ReadInt();
            cellsType = reader.ReadSbyte();
            

}


}


}