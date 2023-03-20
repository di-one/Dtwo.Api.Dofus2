


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
{

public const uint Id = 9569;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actorEventId;
        

public GameRolePlayShowActorWithEventMessage()
{
}

public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(actorEventId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            actorEventId = reader.ReadSbyte();
            

}


}


}