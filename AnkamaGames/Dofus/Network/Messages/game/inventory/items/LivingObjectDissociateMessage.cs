


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LivingObjectDissociateMessage : Dofus2Message
{

public const uint Id = 1131;
public override uint MessageId
{
    get { return Id; }
}

public uint livingUID;
        public byte livingPosition;
        

public LivingObjectDissociateMessage()
{
}

public LivingObjectDissociateMessage(uint livingUID, byte livingPosition)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
            

}

public override void Deserialize(IDataReader reader)
{

livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
            

}


}


}