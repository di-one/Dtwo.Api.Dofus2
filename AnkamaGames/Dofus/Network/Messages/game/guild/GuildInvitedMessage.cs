


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildInvitedMessage : Dofus2Message
{

public const uint Id = 2525;
public override uint MessageId
{
    get { return Id; }
}

public double recruterId;
        public string recruterName;
        public Types.GuildInformations guildInfo;
        

public GuildInvitedMessage()
{
}

public GuildInvitedMessage(double recruterId, string recruterName, Types.GuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

recruterId = reader.ReadVarUhLong();
            recruterName = reader.ReadUTF();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            

}


}


}