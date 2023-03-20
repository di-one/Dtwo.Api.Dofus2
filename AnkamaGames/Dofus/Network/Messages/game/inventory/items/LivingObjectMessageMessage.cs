


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LivingObjectMessageMessage : Dofus2Message
{

public const uint Id = 6479;
public override uint MessageId
{
    get { return Id; }
}

public uint msgId;
        public int timeStamp;
        public string owner;
        public uint objectGenericId;
        

public LivingObjectMessageMessage()
{
}

public LivingObjectMessageMessage(uint msgId, int timeStamp, string owner, uint objectGenericId)
        {
            this.msgId = msgId;
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.objectGenericId = objectGenericId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)msgId);
            writer.WriteInt(timeStamp);
            writer.WriteUTF(owner);
            writer.WriteVarInt((int)objectGenericId);
            

}

public override void Deserialize(IDataReader reader)
{

msgId = reader.ReadVarUhShort();
            timeStamp = reader.ReadInt();
            owner = reader.ReadUTF();
            objectGenericId = reader.ReadVarUhInt();
            

}


}


}