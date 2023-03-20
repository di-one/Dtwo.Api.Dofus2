


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServerExperienceModificatorMessage : Dofus2Message
{

public const uint Id = 6426;
public override uint MessageId
{
    get { return Id; }
}

public uint experiencePercent;
        

public ServerExperienceModificatorMessage()
{
}

public ServerExperienceModificatorMessage(uint experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)experiencePercent);
            

}

public override void Deserialize(IDataReader reader)
{

experiencePercent = reader.ReadVarUhShort();
            

}


}


}