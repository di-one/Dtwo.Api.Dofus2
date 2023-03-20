


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementListMessage : Dofus2Message
{

public const uint Id = 5488;
public override uint MessageId
{
    get { return Id; }
}

public Types.AchievementAchieved[] finishedAchievements;
        

public AchievementListMessage()
{
}

public AchievementListMessage(Types.AchievementAchieved[] finishedAchievements)
        {
            this.finishedAchievements = finishedAchievements;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)finishedAchievements.Length);
            foreach (var entry in finishedAchievements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            finishedAchievements = new Types.AchievementAchieved[limit];
            for (int i = 0; i < limit; i++)
            {
                 finishedAchievements[i] = ProtocolTypeManager.GetInstance<Types.AchievementAchieved>(reader.ReadUShort());
                 finishedAchievements[i].Deserialize(reader);
            }
            

}


}


}