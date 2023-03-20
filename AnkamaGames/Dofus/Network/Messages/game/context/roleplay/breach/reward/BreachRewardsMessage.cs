


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachRewardsMessage : Dofus2Message
{

public const uint Id = 2148;
public override uint MessageId
{
    get { return Id; }
}

public Types.BreachReward[] rewards;
        

public BreachRewardsMessage()
{
}

public BreachRewardsMessage(Types.BreachReward[] rewards)
        {
            this.rewards = rewards;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)rewards.Length);
            foreach (var entry in rewards)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            rewards = new Types.BreachReward[limit];
            for (int i = 0; i < limit; i++)
            {
                 rewards[i] = new Types.BreachReward();
                 rewards[i].Deserialize(reader);
            }
            

}


}


}