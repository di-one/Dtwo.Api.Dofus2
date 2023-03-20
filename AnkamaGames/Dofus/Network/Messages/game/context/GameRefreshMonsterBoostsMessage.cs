


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRefreshMonsterBoostsMessage : Dofus2Message
{

public const uint Id = 7436;
public override uint MessageId
{
    get { return Id; }
}

public Types.MonsterBoosts[] monsterBoosts;
        public Types.MonsterBoosts[] familyBoosts;
        

public GameRefreshMonsterBoostsMessage()
{
}

public GameRefreshMonsterBoostsMessage(Types.MonsterBoosts[] monsterBoosts, Types.MonsterBoosts[] familyBoosts)
        {
            this.monsterBoosts = monsterBoosts;
            this.familyBoosts = familyBoosts;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)monsterBoosts.Length);
            foreach (var entry in monsterBoosts)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)familyBoosts.Length);
            foreach (var entry in familyBoosts)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            monsterBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsterBoosts[i] = new Types.MonsterBoosts();
                 monsterBoosts[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            familyBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 familyBoosts[i] = new Types.MonsterBoosts();
                 familyBoosts[i].Deserialize(reader);
            }
            

}


}


}