


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TaxCollectorStateUpdateMessage : Dofus2Message
{

public const uint Id = 223;
public override uint MessageId
{
    get { return Id; }
}

public double uniqueId;
        public sbyte state;
        

public TaxCollectorStateUpdateMessage()
{
}

public TaxCollectorStateUpdateMessage(double uniqueId, sbyte state)
        {
            this.uniqueId = uniqueId;
            this.state = state;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(uniqueId);
            writer.WriteSbyte(state);
            

}

public override void Deserialize(IDataReader reader)
{

uniqueId = reader.ReadDouble();
            state = reader.ReadSbyte();
            

}


}


}