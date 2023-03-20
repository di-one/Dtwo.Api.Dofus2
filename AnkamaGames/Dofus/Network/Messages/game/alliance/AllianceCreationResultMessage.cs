


















// Generated on 01/22/2023 17:42:39
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AllianceCreationResultMessage : Dofus2Message
{

public const uint Id = 5395;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        

public AllianceCreationResultMessage()
{
}

public AllianceCreationResultMessage(sbyte result)
        {
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            

}

public override void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            

}


}


}