


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FinishMoveInformations
{

public const short Id = 5282;
public virtual short TypeId
{
    get { return Id; }
}

public int finishMoveId;
        public bool finishMoveState;
        

public FinishMoveInformations()
{
}

public FinishMoveInformations(int finishMoveId, bool finishMoveState)
        {
            this.finishMoveId = finishMoveId;
            this.finishMoveState = finishMoveState;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(finishMoveId);
            writer.WriteBoolean(finishMoveState);
            

}

public virtual void Deserialize(IDataReader reader)
{

finishMoveId = reader.ReadInt();
            finishMoveState = reader.ReadBoolean();
            

}


}


}