


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class QuestObjectiveInformations
{

public const short Id = 3887;
public virtual short TypeId
{
    get { return Id; }
}

public uint objectiveId;
        public bool objectiveStatus;
        public string[] dialogParams;
        

public QuestObjectiveInformations()
{
}

public QuestObjectiveInformations(uint objectiveId, bool objectiveStatus, string[] dialogParams)
        {
            this.objectiveId = objectiveId;
            this.objectiveStatus = objectiveStatus;
            this.dialogParams = dialogParams;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)objectiveId);
            writer.WriteBoolean(objectiveStatus);
            writer.WriteShort((short)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

objectiveId = reader.ReadVarUhShort();
            objectiveStatus = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            

}


}


}