


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlmanachCalendarDateMessage : Dofus2Message
{

public const uint Id = 2378;
public override uint MessageId
{
    get { return Id; }
}

public int date;
        

public AlmanachCalendarDateMessage()
{
}

public AlmanachCalendarDateMessage(int date)
        {
            this.date = date;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(date);
            

}

public override void Deserialize(IDataReader reader)
{

date = reader.ReadInt();
            

}


}


}