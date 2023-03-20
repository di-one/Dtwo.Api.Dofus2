


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PaginationRequestAbstractMessage : Dofus2Message
{

public const uint Id = 4893;
public override uint MessageId
{
    get { return Id; }
}

public double offset;
        public uint count;
        

public PaginationRequestAbstractMessage()
{
}

public PaginationRequestAbstractMessage(double offset, uint count)
        {
            this.offset = offset;
            this.count = count;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(offset);
            writer.WriteUInt(count);
            

}

public override void Deserialize(IDataReader reader)
{

offset = reader.ReadDouble();
            count = reader.ReadUInt();
            

}


}


}