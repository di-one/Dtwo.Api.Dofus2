


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TreasureHuntAvailableRetryCountUpdateMessage : Dofus2Message
{

public const uint Id = 7523;
public override uint MessageId
{
    get { return Id; }
}

public sbyte questType;
        public int availableRetryCount;
        

public TreasureHuntAvailableRetryCountUpdateMessage()
{
}

public TreasureHuntAvailableRetryCountUpdateMessage(sbyte questType, int availableRetryCount)
        {
            this.questType = questType;
            this.availableRetryCount = availableRetryCount;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(questType);
            writer.WriteInt(availableRetryCount);
            

}

public override void Deserialize(IDataReader reader)
{

questType = reader.ReadSbyte();
            availableRetryCount = reader.ReadInt();
            

}


}


}