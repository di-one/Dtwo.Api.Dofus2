


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class QuestStepInfoMessage : Dofus2Message
{

public const uint Id = 4313;
public override uint MessageId
{
    get { return Id; }
}

public Types.QuestActiveInformations infos;
        

public QuestStepInfoMessage()
{
}

public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

infos = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            

}


}


}