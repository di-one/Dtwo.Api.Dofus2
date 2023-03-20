


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ChangeThemeRequestMessage : Dofus2Message
{

public const uint Id = 451;
public override uint MessageId
{
    get { return Id; }
}

public sbyte theme;
        

public ChangeThemeRequestMessage()
{
}

public ChangeThemeRequestMessage(sbyte theme)
        {
            this.theme = theme;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(theme);
            

}

public override void Deserialize(IDataReader reader)
{

theme = reader.ReadSbyte();
            

}


}


}