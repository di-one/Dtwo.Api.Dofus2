


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapRunningFightDetailsRequestMessage : Dofus2Message
{

public const uint Id = 1031;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        

public MapRunningFightDetailsRequestMessage()
{
}

public MapRunningFightDetailsRequestMessage(uint fightId)
        {
            this.fightId = fightId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            

}


}


}