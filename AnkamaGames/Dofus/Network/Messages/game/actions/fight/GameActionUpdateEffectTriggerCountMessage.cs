


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionUpdateEffectTriggerCountMessage : Dofus2Message
{

public const uint Id = 1601;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightEffectTriggerCount[] targetIds;
        

public GameActionUpdateEffectTriggerCountMessage()
{
}

public GameActionUpdateEffectTriggerCountMessage(Types.GameFightEffectTriggerCount[] targetIds)
        {
            this.targetIds = targetIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)targetIds.Length);
            foreach (var entry in targetIds)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            targetIds = new Types.GameFightEffectTriggerCount[limit];
            for (int i = 0; i < limit; i++)
            {
                 targetIds[i] = new Types.GameFightEffectTriggerCount();
                 targetIds[i].Deserialize(reader);
            }
            

}


}


}