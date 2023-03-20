


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class QuestObjectiveInformationsWithCompletion : QuestObjectiveInformations
{

public const short Id = 765;
public override short TypeId
{
    get { return Id; }
}

public uint curCompletion;
        public uint maxCompletion;
        

public QuestObjectiveInformationsWithCompletion()
{
}

public QuestObjectiveInformationsWithCompletion(uint objectiveId, bool objectiveStatus, string[] dialogParams, uint curCompletion, uint maxCompletion)
         : base(objectiveId, objectiveStatus, dialogParams)
        {
            this.curCompletion = curCompletion;
            this.maxCompletion = maxCompletion;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)curCompletion);
            writer.WriteVarShort((int)maxCompletion);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            curCompletion = reader.ReadVarUhShort();
            maxCompletion = reader.ReadVarUhShort();
            

}


}


}