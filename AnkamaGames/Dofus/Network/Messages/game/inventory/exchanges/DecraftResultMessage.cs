


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DecraftResultMessage : Dofus2Message
{

public const uint Id = 5645;
public override uint MessageId
{
    get { return Id; }
}

public Types.DecraftedItemStackInfo[] results;
        

public DecraftResultMessage()
{
}

public DecraftResultMessage(Types.DecraftedItemStackInfo[] results)
        {
            this.results = results;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)results.Length);
            foreach (var entry in results)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            results = new Types.DecraftedItemStackInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 results[i] = new Types.DecraftedItemStackInfo();
                 results[i].Deserialize(reader);
            }
            

}


}


}