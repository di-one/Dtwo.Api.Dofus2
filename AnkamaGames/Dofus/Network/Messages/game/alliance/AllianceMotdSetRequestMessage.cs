


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 21;
public override uint MessageId
{
    get { return Id; }
}

public string content;
        

public AllianceMotdSetRequestMessage()
{
}

public AllianceMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            

}


}


}