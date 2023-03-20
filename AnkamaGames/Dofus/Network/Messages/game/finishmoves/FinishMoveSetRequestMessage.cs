


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class FinishMoveSetRequestMessage : Dofus2Message
{

public const uint Id = 4451;
public override uint MessageId
{
    get { return Id; }
}

public int finishMoveId;
        public bool finishMoveState;
        

public FinishMoveSetRequestMessage()
{
}

public FinishMoveSetRequestMessage(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
            

}

public override void Deserialize(IDataReader reader)
{

finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
            

}


}


}