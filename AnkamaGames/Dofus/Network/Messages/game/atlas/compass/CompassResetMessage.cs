


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CompassResetMessage : Dofus2Message
{

public const uint Id = 4969;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        

public CompassResetMessage()
{
}

public CompassResetMessage(sbyte type)
        {
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            

}


}


}