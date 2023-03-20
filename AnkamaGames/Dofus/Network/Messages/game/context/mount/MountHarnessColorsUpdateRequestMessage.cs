


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountHarnessColorsUpdateRequestMessage : Dofus2Message
{

public const uint Id = 285;
public override uint MessageId
{
    get { return Id; }
}

public bool useHarnessColors;
        

public MountHarnessColorsUpdateRequestMessage()
{
}

public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
        {
            this.useHarnessColors = useHarnessColors;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(useHarnessColors);
            

}

public override void Deserialize(IDataReader reader)
{

useHarnessColors = reader.ReadBoolean();
            

}


}


}