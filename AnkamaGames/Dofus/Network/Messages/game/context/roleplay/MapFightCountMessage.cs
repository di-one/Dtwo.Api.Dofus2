


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapFightCountMessage : Dofus2Message
{

public const uint Id = 5031;
public override uint MessageId
{
    get { return Id; }
}

public uint fightCount;
        

public MapFightCountMessage()
{
}

public MapFightCountMessage(uint fightCount)
        {
            this.fightCount = fightCount;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightCount);
            

}

public override void Deserialize(IDataReader reader)
{

fightCount = reader.ReadVarUhShort();
            

}


}


}