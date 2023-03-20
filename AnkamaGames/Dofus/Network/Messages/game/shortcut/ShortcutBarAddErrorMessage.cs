


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ShortcutBarAddErrorMessage : Dofus2Message
{

public const uint Id = 1299;
public override uint MessageId
{
    get { return Id; }
}

public sbyte error;
        

public ShortcutBarAddErrorMessage()
{
}

public ShortcutBarAddErrorMessage(sbyte error)
        {
            this.error = error;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(error);
            

}

public override void Deserialize(IDataReader reader)
{

error = reader.ReadSbyte();
            

}


}


}