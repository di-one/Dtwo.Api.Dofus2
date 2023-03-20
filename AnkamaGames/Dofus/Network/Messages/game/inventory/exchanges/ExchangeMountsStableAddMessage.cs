


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeMountsStableAddMessage : Dofus2Message
{

public const uint Id = 1823;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData[] mountDescription;
        

public ExchangeMountsStableAddMessage()
{
}

public ExchangeMountsStableAddMessage(Types.MountClientData[] mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mountDescription.Length);
            foreach (var entry in mountDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mountDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountDescription[i] = new Types.MountClientData();
                 mountDescription[i].Deserialize(reader);
            }
            

}


}


}