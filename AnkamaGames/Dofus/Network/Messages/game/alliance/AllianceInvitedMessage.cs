


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceInvitedMessage : Dofus2Message
{

public const uint Id = 7177;
public override uint MessageId
{
    get { return Id; }
}

public double recruterId;
        public string recruterName;
        public Types.BasicNamedAllianceInformations allianceInfo;
        

public AllianceInvitedMessage()
{
}

public AllianceInvitedMessage(double recruterId, string recruterName, Types.BasicNamedAllianceInformations allianceInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.allianceInfo = allianceInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            allianceInfo.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

recruterId = reader.ReadVarUhLong();
            recruterName = reader.ReadUTF();
            allianceInfo = new Types.BasicNamedAllianceInformations();
            allianceInfo.Deserialize(reader);
            

}


}


}