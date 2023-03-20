


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class WatchQuestStepInfoMessage : QuestStepInfoMessage
{

public const uint Id = 673;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        

public WatchQuestStepInfoMessage()
{
}

public WatchQuestStepInfoMessage(Types.QuestActiveInformations infos, double playerId)
         : base(infos)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            

}


}


}