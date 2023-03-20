


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceChangeGuildRightsMessage : Dofus2Message
{

public const uint Id = 1555;
public override uint MessageId
{
    get { return Id; }
}

public uint guildId;
        public sbyte rights;
        

public AllianceChangeGuildRightsMessage()
{
}

public AllianceChangeGuildRightsMessage(uint guildId, sbyte rights)
        {
            this.guildId = guildId;
            this.rights = rights;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildId);
            writer.WriteSbyte(rights);
            

}

public override void Deserialize(IDataReader reader)
{

guildId = reader.ReadVarUhInt();
            rights = reader.ReadSbyte();
            

}


}


}