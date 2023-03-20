


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class LivingObjectChangeSkinRequestMessage : Dofus2Message
{

public const uint Id = 6916;
public override uint MessageId
{
    get { return Id; }
}

public uint livingUID;
        public byte livingPosition;
        public uint skinId;
        

public LivingObjectChangeSkinRequestMessage()
{
}

public LivingObjectChangeSkinRequestMessage(uint livingUID, byte livingPosition, uint skinId)
        {
            this.livingUID = livingUID;
            this.livingPosition = livingPosition;
            this.skinId = skinId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)livingUID);
            writer.WriteByte(livingPosition);
            writer.WriteVarInt((int)skinId);
            

}

public override void Deserialize(IDataReader reader)
{

livingUID = reader.ReadVarUhInt();
            livingPosition = reader.ReadByte();
            skinId = reader.ReadVarUhInt();
            

}


}


}