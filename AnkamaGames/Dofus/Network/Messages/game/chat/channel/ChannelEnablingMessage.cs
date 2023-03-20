


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChannelEnablingMessage : Dofus2Message
{

public const uint Id = 1675;
public override uint MessageId
{
    get { return Id; }
}

public sbyte channel;
        public bool enable;
        

public ChannelEnablingMessage()
{
}

public ChannelEnablingMessage(sbyte channel, bool enable)
        {
            this.channel = channel;
            this.enable = enable;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(channel);
            writer.WriteBoolean(enable);
            

}

public override void Deserialize(IDataReader reader)
{

channel = reader.ReadSbyte();
            enable = reader.ReadBoolean();
            

}


}


}