


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class OrnamentSelectRequestMessage : Dofus2Message
{

public const uint Id = 1968;
public override uint MessageId
{
    get { return Id; }
}

public uint ornamentId;
        

public OrnamentSelectRequestMessage()
{
}

public OrnamentSelectRequestMessage(uint ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)ornamentId);
            

}

public override void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadVarUhShort();
            

}


}


}