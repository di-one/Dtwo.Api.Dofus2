


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceJoinedMessage : Dofus2Message
{

public const uint Id = 230;
public override uint MessageId
{
    get { return Id; }
}

public Types.AllianceInformations allianceInfo;
        public bool enabled;
        public uint leadingGuildId;
        

public AllianceJoinedMessage()
{
}

public AllianceJoinedMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
        {
            this.allianceInfo = allianceInfo;
            this.enabled = enabled;
            this.leadingGuildId = leadingGuildId;
        }
        

public override void Serialize(IDataWriter writer)
{

allianceInfo.Serialize(writer);
            writer.WriteBoolean(enabled);
            writer.WriteVarInt((int)leadingGuildId);
            

}

public override void Deserialize(IDataReader reader)
{

allianceInfo = new Types.AllianceInformations();
            allianceInfo.Deserialize(reader);
            enabled = reader.ReadBoolean();
            leadingGuildId = reader.ReadVarUhInt();
            

}


}


}