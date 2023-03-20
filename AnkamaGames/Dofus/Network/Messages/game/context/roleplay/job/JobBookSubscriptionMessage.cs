


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class JobBookSubscriptionMessage : Dofus2Message
{

public const uint Id = 3574;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobBookSubscription[] subscriptions;
        

public JobBookSubscriptionMessage()
{
}

public JobBookSubscriptionMessage(Types.JobBookSubscription[] subscriptions)
        {
            this.subscriptions = subscriptions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)subscriptions.Length);
            foreach (var entry in subscriptions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            subscriptions = new Types.JobBookSubscription[limit];
            for (int i = 0; i < limit; i++)
            {
                 subscriptions[i] = new Types.JobBookSubscription();
                 subscriptions[i].Deserialize(reader);
            }
            

}


}


}