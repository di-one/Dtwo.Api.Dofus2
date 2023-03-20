


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MimicryObjectAssociatedMessage : SymbioticObjectAssociatedMessage
{

public const uint Id = 4804;
public override uint MessageId
{
    get { return Id; }
}



public MimicryObjectAssociatedMessage()
{
}

public MimicryObjectAssociatedMessage(uint hostUID)
         : base(hostUID)
        {
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}