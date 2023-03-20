


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AnomalyStateMessage : Dofus2Message
{

public const uint Id = 1610;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public bool open;
        public double closingTime;
        

public AnomalyStateMessage()
{
}

public AnomalyStateMessage(uint subAreaId, bool open, double closingTime)
        {
            this.subAreaId = subAreaId;
            this.open = open;
            this.closingTime = closingTime;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(open);
            writer.WriteVarLong(closingTime);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            open = reader.ReadBoolean();
            closingTime = reader.ReadVarUhLong();
            

}


}


}