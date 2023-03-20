


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntFlagRemoveRequestMessage : Dofus2Message
{

public const uint Id = 1209;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public sbyte index;
        

public TreasureHuntFlagRemoveRequestMessage()
{
}

public TreasureHuntFlagRemoveRequestMessage(sbyte questType, sbyte index)
        {
            this.questType = questType;
            this.index = index;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteSbyte(index);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            index = reader.ReadSbyte();
            

}


}


}