


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MountSetXpRatioRequestMessage : Dofus2Message
{

public const uint Id = 7292;
public override uint MessageId
{
    get { return Id; }
}

public sbyte xpRatio;
        

public MountSetXpRatioRequestMessage()
{
}

public MountSetXpRatioRequestMessage(sbyte xpRatio)
        {
            this.xpRatio = xpRatio;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(xpRatio);
            

}

public override void Deserialize(IDataReader reader)
{

xpRatio = reader.ReadSbyte();
            

}


}


}