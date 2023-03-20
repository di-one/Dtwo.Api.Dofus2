


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class QuestStartRequestMessage : Dofus2Message
{

public const uint Id = 8660;
public override uint MessageId
{
    get { return Id; }
}

public uint questId;
        

public QuestStartRequestMessage()
{
}

public QuestStartRequestMessage(uint questId)
        {
            this.questId = questId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            

}

public override void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            

}


}


}