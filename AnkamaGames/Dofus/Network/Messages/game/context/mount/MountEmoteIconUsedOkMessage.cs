


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountEmoteIconUsedOkMessage : Dofus2Message
{

public const uint Id = 4509;
public override uint MessageId
{
    get { return Id; }
}

public int mountId;
        public sbyte reactionType;
        

public MountEmoteIconUsedOkMessage()
{
}

public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)mountId);
            writer.WriteSbyte(reactionType);
            

}

public override void Deserialize(IDataReader reader)
{

mountId = reader.ReadVarInt();
            reactionType = reader.ReadSbyte();
            

}


}


}