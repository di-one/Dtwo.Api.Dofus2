


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismFightSwapRequestMessage : Dofus2Message
{

public const uint Id = 5555;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public double targetId;
        

public PrismFightSwapRequestMessage()
{
}

public PrismFightSwapRequestMessage(uint subAreaId, double targetId)
        {
            this.subAreaId = subAreaId;
            this.targetId = targetId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarLong(targetId);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            targetId = reader.ReadVarUhLong();
            

}


}


}