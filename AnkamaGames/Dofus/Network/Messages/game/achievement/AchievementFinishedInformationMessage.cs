


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AchievementFinishedInformationMessage : AchievementFinishedMessage
{

public const uint Id = 8846;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public double playerId;
        

public AchievementFinishedInformationMessage()
{
}

public AchievementFinishedInformationMessage(Types.AchievementAchievedRewardable achievement, string name, double playerId)
         : base(achievement)
        {
            this.name = name;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            

}


}


}