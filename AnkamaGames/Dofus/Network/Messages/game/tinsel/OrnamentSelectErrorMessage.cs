


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class OrnamentSelectErrorMessage : Dofus2Message
{

public const uint Id = 4934;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public OrnamentSelectErrorMessage()
{
}

public OrnamentSelectErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            

}

public override void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            

}


}


}