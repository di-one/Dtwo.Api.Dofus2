


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class UpdateRecruitmentInformationMessage : Dofus2Message
{

public const uint Id = 9009;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildRecruitmentInformation recruitmentData;
        

public UpdateRecruitmentInformationMessage()
{
}

public UpdateRecruitmentInformationMessage(Types.GuildRecruitmentInformation recruitmentData)
        {
            this.recruitmentData = recruitmentData;
        }
        

public override void Serialize(IDataWriter writer)
{

recruitmentData.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

recruitmentData = new Types.GuildRecruitmentInformation();
            recruitmentData.Deserialize(reader);
            

}


}


}