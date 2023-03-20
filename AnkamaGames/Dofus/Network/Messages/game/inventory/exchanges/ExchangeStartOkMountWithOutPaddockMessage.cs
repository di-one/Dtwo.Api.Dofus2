


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkMountWithOutPaddockMessage : Dofus2Message
{

public const uint Id = 4924;
public override uint MessageId
{
    get { return Id; }
}

public Types.MountClientData[] stabledMountsDescription;
        

public ExchangeStartOkMountWithOutPaddockMessage()
{
}

public ExchangeStartOkMountWithOutPaddockMessage(Types.MountClientData[] stabledMountsDescription)
        {
            this.stabledMountsDescription = stabledMountsDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)stabledMountsDescription.Length);
            foreach (var entry in stabledMountsDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            stabledMountsDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 stabledMountsDescription[i] = new Types.MountClientData();
                 stabledMountsDescription[i].Deserialize(reader);
            }
            

}


}


}