


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IdolPartyLostMessage : Dofus2Message
{

public const uint Id = 6894;
public override uint MessageId
{
    get { return Id; }
}

public uint idolId;
        

public IdolPartyLostMessage()
{
}

public IdolPartyLostMessage(uint idolId)
        {
            this.idolId = idolId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)idolId);
            

}

public override void Deserialize(IDataReader reader)
{

idolId = reader.ReadVarUhShort();
            

}


}


}