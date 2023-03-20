


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicAckMessage : Dofus2Message
{

public const uint Id = 4644;
public override uint MessageId
{
    get { return Id; }
}

public uint seq;
        public uint lastPacketId;
        

public BasicAckMessage()
{
}

public BasicAckMessage(uint seq, uint lastPacketId)
        {
            this.seq = seq;
            this.lastPacketId = lastPacketId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)seq);
            writer.WriteVarShort((int)lastPacketId);
            

}

public override void Deserialize(IDataReader reader)
{

seq = reader.ReadVarUhInt();
            lastPacketId = reader.ReadVarUhShort();
            

}


}


}