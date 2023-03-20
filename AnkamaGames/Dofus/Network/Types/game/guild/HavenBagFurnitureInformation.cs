


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HavenBagFurnitureInformation
{

public const short Id = 1499;
public virtual short TypeId
{
    get { return Id; }
}

public uint cellId;
        public int funitureId;
        public sbyte orientation;
        

public HavenBagFurnitureInformation()
{
}

public HavenBagFurnitureInformation(uint cellId, int funitureId, sbyte orientation)
        {
            this.cellId = cellId;
            this.funitureId = funitureId;
            this.orientation = orientation;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cellId);
            writer.WriteInt(funitureId);
            writer.WriteSbyte(orientation);
            

}

public virtual void Deserialize(IDataReader reader)
{

cellId = reader.ReadVarUhShort();
            funitureId = reader.ReadInt();
            orientation = reader.ReadSbyte();
            

}


}


}