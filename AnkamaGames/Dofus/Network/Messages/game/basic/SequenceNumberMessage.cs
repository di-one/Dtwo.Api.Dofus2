


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SequenceNumberMessage : Dofus2Message
{

public const uint Id = 8313;
public override uint MessageId
{
    get { return Id; }
}

public ushort number;
        

public SequenceNumberMessage()
{
}

public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(number);
            

}

public override void Deserialize(IDataReader reader)
{

number = reader.ReadUShort();
            

}


}


}