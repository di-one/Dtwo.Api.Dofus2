


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BasicDateMessage : Dofus2Message
{

public const uint Id = 609;
public override uint MessageId
{
    get { return Id; }
}

public sbyte day;
        public sbyte month;
        public short year;
        

public BasicDateMessage()
{
}

public BasicDateMessage(sbyte day, sbyte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(day);
            writer.WriteSbyte(month);
            writer.WriteShort(year);
            

}

public override void Deserialize(IDataReader reader)
{

day = reader.ReadSbyte();
            month = reader.ReadSbyte();
            year = reader.ReadShort();
            

}


}


}