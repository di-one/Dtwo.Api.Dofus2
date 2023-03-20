


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ActivityHideRequestMessage : Dofus2Message
{

public const uint Id = 990;
public override uint MessageId
{
    get { return Id; }
}

public uint activityId;
        

public ActivityHideRequestMessage()
{
}

public ActivityHideRequestMessage(uint activityId)
        {
            this.activityId = activityId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)activityId);
            

}

public override void Deserialize(IDataReader reader)
{

activityId = reader.ReadVarUhShort();
            

}


}


}