


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LeaveDialogMessage : Dofus2Message
{

public const uint Id = 115;
public override uint MessageId
{
    get { return Id; }
}

public sbyte dialogType;
        

public LeaveDialogMessage()
{
}

public LeaveDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(dialogType);
            

}

public override void Deserialize(IDataReader reader)
{

dialogType = reader.ReadSbyte();
            

}


}


}