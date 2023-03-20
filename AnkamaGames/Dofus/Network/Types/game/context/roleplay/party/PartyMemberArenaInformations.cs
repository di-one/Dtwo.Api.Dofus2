


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PartyMemberArenaInformations : PartyMemberInformations
{

public const short Id = 5619;
public override short TypeId
{
    get { return Id; }
}

public uint rank;
        

public PartyMemberArenaInformations()
{
}

public PartyMemberArenaInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex, uint lifePoints, uint maxLifePoints, uint prospecting, byte regenRate, uint initiative, sbyte alignmentSide, short worldX, short worldY, double mapId, uint subAreaId, Types.PlayerStatus status, Types.PartyEntityBaseInformation[] entities, uint rank)
         : base(id, name, level, entityLook, breed, sex, lifePoints, maxLifePoints, prospecting, regenRate, initiative, alignmentSide, worldX, worldY, mapId, subAreaId, status, entities)
        {
            this.rank = rank;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)rank);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            rank = reader.ReadVarUhShort();
            

}


}


}