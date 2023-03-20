


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaddockToSellFilterMessage : Dofus2Message
{

public const uint Id = 1863;
public override uint MessageId
{
    get { return Id; }
}

public int areaId;
        public sbyte atLeastNbMount;
        public sbyte atLeastNbMachine;
        public double maxPrice;
        public sbyte orderBy;
        

public PaddockToSellFilterMessage()
{
}

public PaddockToSellFilterMessage(int areaId, sbyte atLeastNbMount, sbyte atLeastNbMachine, double maxPrice, sbyte orderBy)
        {
            this.areaId = areaId;
            this.atLeastNbMount = atLeastNbMount;
            this.atLeastNbMachine = atLeastNbMachine;
            this.maxPrice = maxPrice;
            this.orderBy = orderBy;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(areaId);
            writer.WriteSbyte(atLeastNbMount);
            writer.WriteSbyte(atLeastNbMachine);
            writer.WriteVarLong(maxPrice);
            writer.WriteSbyte(orderBy);
            

}

public override void Deserialize(IDataReader reader)
{

areaId = reader.ReadInt();
            atLeastNbMount = reader.ReadSbyte();
            atLeastNbMachine = reader.ReadSbyte();
            maxPrice = reader.ReadVarUhLong();
            orderBy = reader.ReadSbyte();
            

}


}


}