


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChallengeTargetsListRequestMessage : Dofus2Message
{

public const uint Id = 2836;
public override uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        

public ChallengeTargetsListRequestMessage()
{
}

public ChallengeTargetsListRequestMessage(uint challengeId)
        {
            this.challengeId = challengeId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            

}


}


}