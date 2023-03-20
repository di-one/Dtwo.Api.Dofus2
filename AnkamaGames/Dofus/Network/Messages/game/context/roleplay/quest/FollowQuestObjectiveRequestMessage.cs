


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FollowQuestObjectiveRequestMessage : Dofus2Message
{

public const uint Id = 2060;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        public short objectiveId;
        

public FollowQuestObjectiveRequestMessage()
{
}

public FollowQuestObjectiveRequestMessage(uint questId, short objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteShort(objectiveId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            objectiveId = reader.ReadShort();
            

}


}


}