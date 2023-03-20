


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChallengeResultMessage : Dofus2Message
{

public const uint Id = 8340;
public override uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public bool success;
        

public ChallengeResultMessage()
{
}

public ChallengeResultMessage(uint challengeId, bool success)
        {
            this.challengeId = challengeId;
            this.success = success;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteBoolean(success);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            success = reader.ReadBoolean();
            

}


}


}