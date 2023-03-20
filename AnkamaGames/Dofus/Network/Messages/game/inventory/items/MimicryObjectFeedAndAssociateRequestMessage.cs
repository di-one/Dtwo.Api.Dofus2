


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
{

public const uint Id = 1674;
public override uint MessageId
{
    get { return Id; }
}

public uint foodUID;
        public byte foodPos;
        public bool preview;
        

public MimicryObjectFeedAndAssociateRequestMessage()
{
}

public MimicryObjectFeedAndAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos, uint foodUID, byte foodPos, bool preview)
         : base(symbioteUID, symbiotePos, hostUID, hostPos)
        {
            this.foodUID = foodUID;
            this.foodPos = foodPos;
            this.preview = preview;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)foodUID);
            writer.WriteByte(foodPos);
            writer.WriteBoolean(preview);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            foodUID = reader.ReadVarUhInt();
            foodPos = reader.ReadByte();
            preview = reader.ReadBoolean();
            

}


}


}