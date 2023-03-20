


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntFlagRequestAnswerMessage : Dofus2Message
{

public const uint Id = 4502;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte result;
        public sbyte index;
        

public TreasureHuntFlagRequestAnswerMessage()
{
}

public TreasureHuntFlagRequestAnswerMessage(sbyte questType, sbyte result, sbyte index)
        {
            this.questType = questType;
            this.result = result;
            this.index = index;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteSbyte(result);
            writer.WriteSbyte(index);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            result = reader.ReadSbyte();
            index = reader.ReadSbyte();
            

}


}


}