


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
{

public const uint Id = 6088;
public override uint MessageId
{
    get { return Id; }
}

public sbyte wrongFlagCount;
        

public TreasureHuntDigRequestAnswerFailedMessage()
{
}

public TreasureHuntDigRequestAnswerFailedMessage(sbyte questType, sbyte result, sbyte wrongFlagCount)
         : base(questType, result)
        {
            this.wrongFlagCount = wrongFlagCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(wrongFlagCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            wrongFlagCount = reader.ReadSbyte();
            

}


}


}