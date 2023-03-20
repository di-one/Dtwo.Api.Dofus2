


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TreasureHuntFlag
{

public const short Id = 1394;
public virtual short TypeId
{
    get { return Id; }
}

public double mapId;
        public sbyte state;
        

public TreasureHuntFlag()
{
}

public TreasureHuntFlag(double mapId, sbyte state)
        {
            this.mapId = mapId;
            this.state = state;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteSbyte(state);
            

}

public virtual void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            state = reader.ReadSbyte();
            

}


}


}