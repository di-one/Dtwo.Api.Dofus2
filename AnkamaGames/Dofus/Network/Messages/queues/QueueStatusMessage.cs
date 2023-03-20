


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class QueueStatusMessage : Dofus2Message
{

public const uint Id = 5360;
public override uint MessageId
{
    get { return Id; }
}

public ushort position;
        public ushort total;
        

public QueueStatusMessage()
{
}

public QueueStatusMessage(ushort position, ushort total)
        {
            this.position = position;
            this.total = total;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUShort(position);
            writer.WriteUShort(total);
            

}

public override void Deserialize(IDataReader reader)
{

position = reader.ReadUShort();
            total = reader.ReadUShort();
            

}


}


}