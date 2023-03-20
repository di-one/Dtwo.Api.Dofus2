


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildUpdateApplicationMessage : Dofus2Message
{

public const uint Id = 7375;
public override uint MessageId
{
    get { return Id; }
}

public string applyText;
        public uint guildId;
        

public GuildUpdateApplicationMessage()
{
}

public GuildUpdateApplicationMessage(string applyText, uint guildId)
        {
            this.applyText = applyText;
            this.guildId = guildId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(applyText);
            writer.WriteVarInt((int)guildId);
            

}

public override void Deserialize(IDataReader reader)
{

applyText = reader.ReadUTF();
            guildId = reader.ReadVarUhInt();
            

}


}


}