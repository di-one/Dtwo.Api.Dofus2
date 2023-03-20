


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EvolutiveObjectRecycleResultMessage : Dofus2Message
{

public const uint Id = 5075;
public override uint MessageId
{
    get { return Id; }
}

public Types.RecycledItem[] recycledItems;
        

public EvolutiveObjectRecycleResultMessage()
{
}

public EvolutiveObjectRecycleResultMessage(Types.RecycledItem[] recycledItems)
        {
            this.recycledItems = recycledItems;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)recycledItems.Length);
            foreach (var entry in recycledItems)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            recycledItems = new Types.RecycledItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 recycledItems[i] = new Types.RecycledItem();
                 recycledItems[i].Deserialize(reader);
            }
            

}


}


}