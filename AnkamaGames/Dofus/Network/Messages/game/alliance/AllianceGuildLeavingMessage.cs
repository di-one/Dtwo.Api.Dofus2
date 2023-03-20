


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceGuildLeavingMessage : Dofus2Message
{

public const uint Id = 1732;
public override uint MessageId
{
    get { return Id; }
}

public bool kicked;
        public uint guildId;
        

public AllianceGuildLeavingMessage()
{
}

public AllianceGuildLeavingMessage(bool kicked, uint guildId)
        {
            this.kicked = kicked;
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(kicked);
            writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

kicked = reader.ReadBoolean();
            guildId = reader.ReadVarUhInt();
            

}


}


}