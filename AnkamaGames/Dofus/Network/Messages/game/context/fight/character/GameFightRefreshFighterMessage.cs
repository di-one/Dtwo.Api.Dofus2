


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightRefreshFighterMessage : Dofus2Message
{

public const uint Id = 462;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameContextActorInformations informations;
        

public GameFightRefreshFighterMessage()
{
}

public GameFightRefreshFighterMessage(Types.GameContextActorInformations informations)
        {
            this.informations = informations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

informations = ProtocolTypeManager.GetInstance<Types.GameContextActorInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
            

}


}


}