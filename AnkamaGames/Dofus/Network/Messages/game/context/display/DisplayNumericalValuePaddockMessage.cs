


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DisplayNumericalValuePaddockMessage : Dofus2Message
{

public const uint Id = 4794;
public override uint MessageId
{
    get { return Id; }
}

public int rideId;
        public int value;
        public sbyte type;
        

public DisplayNumericalValuePaddockMessage()
{
}

public DisplayNumericalValuePaddockMessage(int rideId, int value, sbyte type)
        {
            this.rideId = rideId;
            this.value = value;
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(rideId);
            writer.WriteInt(value);
            writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

rideId = reader.ReadInt();
            value = reader.ReadInt();
            type = reader.ReadSbyte();
            

}


}


}