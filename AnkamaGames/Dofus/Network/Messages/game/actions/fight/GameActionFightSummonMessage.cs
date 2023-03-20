


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightSummonMessage : AbstractGameActionMessage
{

public const uint Id = 7224;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations[] summons;
        

public GameActionFightSummonMessage()
{
}

public GameActionFightSummonMessage(uint actionId, double sourceId, Types.GameFightFighterInformations[] summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)summons.Length);
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            summons = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 summons[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
                 summons[i].Deserialize(reader);
            }
            

}


}


}