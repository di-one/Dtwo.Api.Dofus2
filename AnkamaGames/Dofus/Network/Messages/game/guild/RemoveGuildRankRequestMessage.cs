


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class RemoveGuildRankRequestMessage : Dofus2Message
{

public const uint Id = 7055;
public override uint MessageId
{
    get { return Id; }
}

public uint rankId;
        public uint newRankId;
        

public RemoveGuildRankRequestMessage()
{
}

public RemoveGuildRankRequestMessage(uint rankId, uint newRankId)
        {
            this.rankId = rankId;
            this.newRankId = newRankId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)rankId);
            writer.WriteVarInt((int)newRankId);
            

}

public override void Deserialize(IDataReader reader)
{

rankId = reader.ReadVarUhInt();
            newRankId = reader.ReadVarUhInt();
            

}


}


}