


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class QuestStepValidatedMessage : Dofus2Message
{

public const uint Id = 2465;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        public uint stepId;
        

public QuestStepValidatedMessage()
{
}

public QuestStepValidatedMessage(uint questId, uint stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)stepId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            stepId = reader.ReadVarUhShort();
            

}


}


}