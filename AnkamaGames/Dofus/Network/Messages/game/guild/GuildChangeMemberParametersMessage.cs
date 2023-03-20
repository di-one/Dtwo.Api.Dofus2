


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildChangeMemberParametersMessage : Dofus2Message
{

public const uint Id = 8129;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public uint rankId;
        public sbyte experienceGivenPercent;
        

public GuildChangeMemberParametersMessage()
{
}

public GuildChangeMemberParametersMessage(double memberId, uint rankId, sbyte experienceGivenPercent)
        {
            this.memberId = memberId;
            this.rankId = rankId;
            this.experienceGivenPercent = experienceGivenPercent;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteVarInt((int)rankId);
            writer.WriteSbyte(experienceGivenPercent);
            

}

public override void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            rankId = reader.ReadVarUhInt();
            experienceGivenPercent = reader.ReadSbyte();
            

}


}


}