


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementAlmostFinishedDetailedListMessage : Dofus2Message
{

public const uint Id = 2807;
public override uint MessageId
{
    get { return Id; }
}

public Types.Achievement[] almostFinishedAchievements;
        

public AchievementAlmostFinishedDetailedListMessage()
{
}

public AchievementAlmostFinishedDetailedListMessage(Types.Achievement[] almostFinishedAchievements)
        {
            this.almostFinishedAchievements = almostFinishedAchievements;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)almostFinishedAchievements.Length);
            foreach (var entry in almostFinishedAchievements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            almostFinishedAchievements = new Types.Achievement[limit];
            for (int i = 0; i < limit; i++)
            {
                 almostFinishedAchievements[i] = new Types.Achievement();
                 almostFinishedAchievements[i].Deserialize(reader);
            }
            

}


}


}