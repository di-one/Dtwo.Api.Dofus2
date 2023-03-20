


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SetCharacterRestrictionsMessage : Dofus2Message
{

public const uint Id = 2997;
public override uint MessageId
{
    get { return Id; }
}

public double actorId;
        public Types.ActorRestrictionsInformations restrictions;
        

public SetCharacterRestrictionsMessage()
{
}

public SetCharacterRestrictionsMessage(double actorId, Types.ActorRestrictionsInformations restrictions)
        {
            this.actorId = actorId;
            this.restrictions = restrictions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(actorId);
            restrictions.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

actorId = reader.ReadDouble();
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            

}


}


}