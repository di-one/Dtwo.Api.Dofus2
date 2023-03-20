


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HaapiCancelBidRequestMessage : Dofus2Message
{

public const uint Id = 4878;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public sbyte type;
        

public HaapiCancelBidRequestMessage()
{
}

public HaapiCancelBidRequestMessage(double id, sbyte type)
        {
            this.id = id;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            type = reader.ReadSbyte();
            

}


}


}