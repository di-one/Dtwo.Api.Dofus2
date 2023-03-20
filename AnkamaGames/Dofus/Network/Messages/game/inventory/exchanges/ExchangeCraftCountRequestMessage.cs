


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeCraftCountRequestMessage : Dofus2Message
{

public const uint Id = 9737;
public override uint MessageId
{
    get { return Id; }
}

public int count;
        

public ExchangeCraftCountRequestMessage()
{
}

public ExchangeCraftCountRequestMessage(int count)
        {
            this.count = count;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)count);
            

}

public override void Deserialize(IDataReader reader)
{

count = reader.ReadVarInt();
            

}


}


}