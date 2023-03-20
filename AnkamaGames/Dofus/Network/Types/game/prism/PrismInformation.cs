


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PrismInformation
{

public const short Id = 1566;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte typeId;
        public sbyte state;
        public int nextVulnerabilityDate;
        public int placementDate;
        public uint rewardTokenCount;
        

public PrismInformation()
{
}

public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
        {
            this.typeId = typeId;
            this.state = state;
            this.nextVulnerabilityDate = nextVulnerabilityDate;
            this.placementDate = placementDate;
            this.rewardTokenCount = rewardTokenCount;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(typeId);
            writer.WriteSbyte(state);
            writer.WriteInt(nextVulnerabilityDate);
            writer.WriteInt(placementDate);
            writer.WriteVarInt((int)rewardTokenCount);
            

}

public virtual void Deserialize(IDataReader reader)
{

typeId = reader.ReadSbyte();
            state = reader.ReadSbyte();
            nextVulnerabilityDate = reader.ReadInt();
            placementDate = reader.ReadInt();
            rewardTokenCount = reader.ReadVarUhInt();
            

}


}


}