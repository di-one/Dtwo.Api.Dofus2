


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChallengeInfoMessage : Dofus2Message
{

public const uint Id = 3253;
public override uint MessageId
{
    get { return Id; }
}

public uint challengeId;
        public double targetId;
        public uint xpBonus;
        public uint dropBonus;
        

public ChallengeInfoMessage()
{
}

public ChallengeInfoMessage(uint challengeId, double targetId, uint xpBonus, uint dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)xpBonus);
            writer.WriteVarInt((int)dropBonus);
            

}

public override void Deserialize(IDataReader reader)
{

challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            xpBonus = reader.ReadVarUhInt();
            dropBonus = reader.ReadVarUhInt();
            

}


}


}