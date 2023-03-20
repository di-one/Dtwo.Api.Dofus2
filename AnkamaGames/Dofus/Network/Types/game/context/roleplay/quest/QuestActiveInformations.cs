


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class QuestActiveInformations
{

public const short Id = 883;
public virtual short TypeId
{
    get { return Id; }
}

public uint questId;
        

public QuestActiveInformations()
{
}

public QuestActiveInformations(uint questId)
        {
            this.questId = questId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public virtual void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            

}


}


}