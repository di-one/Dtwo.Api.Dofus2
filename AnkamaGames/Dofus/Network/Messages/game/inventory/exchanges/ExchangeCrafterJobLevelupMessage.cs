


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeCrafterJobLevelupMessage : Dofus2Message
{

public const uint Id = 6283;
public override uint MessageId
{
    get { return Id; }
}

public byte crafterJobLevel;
        

public ExchangeCrafterJobLevelupMessage()
{
}

public ExchangeCrafterJobLevelupMessage(byte crafterJobLevel)
        {
            this.crafterJobLevel = crafterJobLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteByte(crafterJobLevel);
            

}

public override void Deserialize(IDataReader reader)
{

crafterJobLevel = reader.ReadByte();
            

}


}


}