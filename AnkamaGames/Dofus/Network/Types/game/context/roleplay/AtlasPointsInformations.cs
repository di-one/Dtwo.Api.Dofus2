


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AtlasPointsInformations
{

public const short Id = 8644;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinatesExtended[] coords;
        

public AtlasPointsInformations()
{
}

public AtlasPointsInformations(sbyte type, Types.MapCoordinatesExtended[] coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort((short)coords.Length);
            foreach (var entry in coords)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            coords = new Types.MapCoordinatesExtended[limit];
            for (int i = 0; i < limit; i++)
            {
                 coords[i] = new Types.MapCoordinatesExtended();
                 coords[i].Deserialize(reader);
            }
            

}


}


}