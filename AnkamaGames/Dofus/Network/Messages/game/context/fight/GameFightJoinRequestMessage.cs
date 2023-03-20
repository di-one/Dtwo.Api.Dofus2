


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightJoinRequestMessage : Dofus2Message
{

public const uint Id = 6094;
public override uint MessageId
{
    get { return Id; }
}

public double fighterId;
        public uint fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(double fighterId, uint fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(fighterId);
            writer.WriteVarShort((int)fightId);
            

}

public override void Deserialize(IDataReader reader)
{

fighterId = reader.ReadDouble();
            fightId = reader.ReadVarUhShort();
            

}


}


}