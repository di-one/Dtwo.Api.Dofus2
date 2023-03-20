


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildModificationStartedMessage : Dofus2Message
{

public const uint Id = 6661;
public override uint MessageId
{
    get { return Id; }
}

public bool canChangeName;
        public bool canChangeEmblem;
        

public GuildModificationStartedMessage()
{
}

public GuildModificationStartedMessage(bool canChangeName, bool canChangeEmblem)
        {
            this.canChangeName = canChangeName;
            this.canChangeEmblem = canChangeEmblem;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, canChangeName);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canChangeEmblem);
            writer.WriteByte(flag1);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            canChangeName = BooleanByteWrapper.GetFlag(flag1, 0);
            canChangeEmblem = BooleanByteWrapper.GetFlag(flag1, 1);
            

}


}


}