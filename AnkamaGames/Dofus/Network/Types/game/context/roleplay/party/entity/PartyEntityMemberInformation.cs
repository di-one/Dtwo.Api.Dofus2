


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PartyEntityMemberInformation : PartyEntityBaseInformation
{

public const short Id = 6691;
public override short TypeId
{
    get { return Id; }
}

public uint initiative;
        public uint lifePoints;
        public uint maxLifePoints;
        public uint prospecting;
        public byte regenRate;
        

public PartyEntityMemberInformation()
{
}

public PartyEntityMemberInformation(sbyte indexId, sbyte entityModelId, Types.EntityLook entityLook, uint initiative, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate)
         : base(indexId, entityModelId, entityLook)
        {
            this.initiative = initiative;
            this.lifePoints = lifePoints;
            this.maxLifePoints = maxLifePoints;
            this.prospecting = prospecting;
            this.regenRate = regenRate;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)initiative);
            writer.WriteVarInt((int)lifePoints);
            writer.WriteVarInt((int)maxLifePoints);
            writer.WriteVarInt((int)prospecting);
            writer.WriteByte(regenRate);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            initiative = reader.ReadVarUhInt();
            lifePoints = reader.ReadVarUhInt();
            maxLifePoints = reader.ReadVarUhInt();
            prospecting = reader.ReadVarUhInt();
            regenRate = reader.ReadByte();
            

}


}


}