


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NotificationUpdateFlagMessage : Dofus2Message
{

public const uint Id = 4763;
public override uint MessageId
{
    get { return Id; }
}

public uint index;
        

public NotificationUpdateFlagMessage()
{
}

public NotificationUpdateFlagMessage(uint index)
        {
            this.index = index;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)index);
            

}

public override void Deserialize(IDataReader reader)
{

index = reader.ReadVarUhShort();
            

}


}


}