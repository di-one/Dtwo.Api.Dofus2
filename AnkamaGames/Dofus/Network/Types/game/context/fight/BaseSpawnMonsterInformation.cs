


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class BaseSpawnMonsterInformation : SpawnInformation
{

public const short Id = 523;
public override short TypeId
{
    get { return Id; }
}

public uint creatureGenericId;
        

public BaseSpawnMonsterInformation()
{
}

public BaseSpawnMonsterInformation(uint creatureGenericId)
        {
            this.creatureGenericId = creatureGenericId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)creatureGenericId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUhShort();
            

}


}


}