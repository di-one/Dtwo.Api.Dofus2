


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicTimeMessage : Dofus2Message
{

public const uint Id = 5815;
public override uint MessageId
{
    get { return Id; }
}

public double timestamp;
        public short timezoneOffset;
        

public BasicTimeMessage()
{
}

public BasicTimeMessage(double timestamp, short timezoneOffset)
        {
            this.timestamp = timestamp;
            this.timezoneOffset = timezoneOffset;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(timestamp);
            writer.WriteShort(timezoneOffset);
            

}

public override void Deserialize(IDataReader reader)
{

timestamp = reader.ReadDouble();
            timezoneOffset = reader.ReadShort();
            

}


}


}