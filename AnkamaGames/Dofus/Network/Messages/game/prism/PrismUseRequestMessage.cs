


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismUseRequestMessage : Dofus2Message
{

public const uint Id = 751;
public override uint MessageId
{
    get { return Id; }
}

public sbyte moduleToUse;
        

public PrismUseRequestMessage()
{
}

public PrismUseRequestMessage(sbyte moduleToUse)
        {
            this.moduleToUse = moduleToUse;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(moduleToUse);
            

}

public override void Deserialize(IDataReader reader)
{

moduleToUse = reader.ReadSbyte();
            

}


}


}