


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HouseInformations
{

public const short Id = 5804;
public virtual short TypeId
{
    get { return Id; }
}

public uint houseId;
        public uint modelId;
        

public HouseInformations()
{
}

public HouseInformations(uint houseId, uint modelId)
        {
            this.houseId = houseId;
            this.modelId = modelId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)houseId);
            writer.WriteVarShort((int)modelId);
            

}

public virtual void Deserialize(IDataReader reader)
{

houseId = reader.ReadVarUhInt();
            modelId = reader.ReadVarUhShort();
            

}


}


}