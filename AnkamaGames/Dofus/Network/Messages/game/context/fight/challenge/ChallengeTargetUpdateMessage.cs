


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChallengeTargetUpdateMessage : Dofus2Message
{

public const uint Id = 6811;
public override uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public double targetId;
        

public ChallengeTargetUpdateMessage()
{
}

public ChallengeTargetUpdateMessage(uint challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            

}


}


}