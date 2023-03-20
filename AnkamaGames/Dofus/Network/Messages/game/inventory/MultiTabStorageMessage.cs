


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MultiTabStorageMessage : Dofus2Message
{

public const uint Id = 3832;
public override uint MessageId
{
    get { return Id; }
}

public Types.StorageTabInformation[] tabs;
        

public MultiTabStorageMessage()
{
}

public MultiTabStorageMessage(Types.StorageTabInformation[] tabs)
        {
            this.tabs = tabs;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)tabs.Length);
            foreach (var entry in tabs)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            tabs = new Types.StorageTabInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 tabs[i] = new Types.StorageTabInformation();
                 tabs[i].Deserialize(reader);
            }
            

}


}


}