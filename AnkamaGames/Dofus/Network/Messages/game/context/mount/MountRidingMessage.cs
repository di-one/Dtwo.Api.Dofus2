


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountRidingMessage : Dofus2Message
{

public const uint Id = 8140;
public override uint MessageId
{
    get { return Id; }
}

public bool isRiding;
        public bool isAutopilot;
        

public MountRidingMessage()
{
}

public MountRidingMessage(bool isRiding, bool isAutopilot)
        {
            this.isRiding = isRiding;
            this.isAutopilot = isAutopilot;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isRiding);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isAutopilot);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isRiding = BooleanByteWrapper.GetFlag(flag1, 0);
            isAutopilot = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}