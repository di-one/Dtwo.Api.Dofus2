


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InteractiveUseWithParamRequestMessage : InteractiveUseRequestMessage
{

public const uint Id = 9538;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public InteractiveUseWithParamRequestMessage()
{
}

public InteractiveUseWithParamRequestMessage(uint elemId, uint skillInstanceUid, int id)
         : base(elemId, skillInstanceUid)
        {
            this.id = id;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(id);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            id = reader.ReadInt();
            

}


}


}