


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightDispellMessage : AbstractGameActionMessage
{

public const uint Id = 6114;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public bool verboseCast;
        

public GameActionFightDispellMessage()
{
}

public GameActionFightDispellMessage(uint actionId, double sourceId, double targetId, bool verboseCast)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.verboseCast = verboseCast;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteBoolean(verboseCast);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            verboseCast = reader.ReadBoolean();
            

}


}


}