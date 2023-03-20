


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SpawnScaledMonsterInformation : BaseSpawnMonsterInformation
{

public const short Id = 5733;
public override short TypeId
{
    get { return Id; }
}

public short creatureLevel;
        

public SpawnScaledMonsterInformation()
{
}

public SpawnScaledMonsterInformation(uint creatureGenericId, short creatureLevel)
         : base(creatureGenericId)
        {
            this.creatureLevel = creatureLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(creatureLevel);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureLevel = reader.ReadShort();
            

}


}


}