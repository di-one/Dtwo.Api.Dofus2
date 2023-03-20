


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntFinishedMessage : Dofus2Message
{

public const uint Id = 8564;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        

public TreasureHuntFinishedMessage()
{
}

public TreasureHuntFinishedMessage(sbyte questType)
        {
            this.questType = questType;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            

}


}


}