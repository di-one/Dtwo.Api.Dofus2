


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class SpawnMonsterInformation : BaseSpawnMonsterInformation
{

public const short Id = 9613;
public override short TypeId
{
    get { return Id; }
}

public sbyte creatureGrade;
        

public SpawnMonsterInformation()
{
}

public SpawnMonsterInformation(uint creatureGenericId, sbyte creatureGrade)
         : base(creatureGenericId)
        {
            this.creatureGrade = creatureGrade;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(creatureGrade);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            creatureGrade = reader.ReadSbyte();
            

}


}


}