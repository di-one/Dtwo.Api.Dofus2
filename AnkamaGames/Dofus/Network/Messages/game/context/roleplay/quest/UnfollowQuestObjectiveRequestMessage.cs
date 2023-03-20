


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UnfollowQuestObjectiveRequestMessage : Dofus2Message
{

public const uint Id = 2764;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        public short objectiveId;
        

public UnfollowQuestObjectiveRequestMessage()
{
}

public UnfollowQuestObjectiveRequestMessage(uint questId, short objectiveId)
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