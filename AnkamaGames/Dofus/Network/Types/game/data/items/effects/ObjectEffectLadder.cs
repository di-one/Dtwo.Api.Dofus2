


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ObjectEffectLadder : ObjectEffectCreature
{

public const short Id = 9939;
public override short TypeId
{
    get { return Id; }
}

public uint monsterCount;
        

public ObjectEffectLadder()
{
}

public ObjectEffectLadder(uint actionId, uint monsterFamilyId, uint monsterCount)
         : base(actionId, monsterFamilyId)
        {
            this.monsterCount = monsterCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)monsterCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            monsterCount = reader.ReadVarUhInt();
            

}


}


}