


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CinematicMessage : Dofus2Message
{

public const uint Id = 8039;
public override uint MessageId
{
    get { return Id; }
}

public uint cinematicId;
        

public CinematicMessage()
{
}

public CinematicMessage(uint cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)cinematicId);
            

}

public override void Deserialize(IDataReader reader)
{

cinematicId = reader.ReadVarUhShort();
            

}


}


}