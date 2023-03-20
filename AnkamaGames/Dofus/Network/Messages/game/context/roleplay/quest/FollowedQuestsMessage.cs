


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FollowedQuestsMessage : Dofus2Message
{

public const uint Id = 3035;
public override uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveDetailedInformations[] quests;
        

public FollowedQuestsMessage()
{
}

public FollowedQuestsMessage(Types.QuestActiveDetailedInformations[] quests)
        {
            this.quests = quests;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)quests.Length);
            foreach (var entry in quests)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            quests = new Types.QuestActiveDetailedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 quests[i] = new Types.QuestActiveDetailedInformations();
                 quests[i].Deserialize(reader);
            }
            

}


}


}