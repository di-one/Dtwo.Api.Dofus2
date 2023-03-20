


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SpawnCompanionInformation : SpawnInformation
{

public const short Id = 2297;
public override short TypeId
{
    get { return Id; }
}

public sbyte modelId;
        public uint level;
        public double summonerId;
        public double ownerId;
        

public SpawnCompanionInformation()
{
}

public SpawnCompanionInformation(sbyte modelId, uint level, double summonerId, double ownerId)
        {
            this.modelId = modelId;
            this.level = level;
            this.summonerId = summonerId;
            this.ownerId = ownerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(modelId);
            writer.WriteVarShort((int)level);
            writer.WriteDouble(summonerId);
            writer.WriteDouble(ownerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            modelId = reader.ReadSbyte();
            level = reader.ReadVarUhShort();
            summonerId = reader.ReadDouble();
            ownerId = reader.ReadDouble();
            

}


}


}