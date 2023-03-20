


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GroupTeleportPlayerAnswerMessage : Dofus2Message
{

public const uint Id = 6708;
public override uint MessageId
{
    get { return Id; }
}

public bool accept;
        public double requesterId;
        

public GroupTeleportPlayerAnswerMessage()
{
}

public GroupTeleportPlayerAnswerMessage(bool accept, double requesterId)
        {
            this.accept = accept;
            this.requesterId = requesterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(accept);
            writer.WriteVarLong(requesterId);
            

}

public override void Deserialize(IDataReader reader)
{

accept = reader.ReadBoolean();
            requesterId = reader.ReadVarUhLong();
            

}


}


}