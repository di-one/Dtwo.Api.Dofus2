


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagFurnituresMessage : Dofus2Message
{

public const uint Id = 7743;
public override uint MessageId
{
    get { return Id; }
}

public Types.HavenBagFurnitureInformation[] furnituresInfos;
        

public HavenBagFurnituresMessage()
{
}

public HavenBagFurnituresMessage(Types.HavenBagFurnitureInformation[] furnituresInfos)
        {
            this.furnituresInfos = furnituresInfos;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)furnituresInfos.Length);
            foreach (var entry in furnituresInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            furnituresInfos = new Types.HavenBagFurnitureInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 furnituresInfos[i] = new Types.HavenBagFurnitureInformation();
                 furnituresInfos[i].Deserialize(reader);
            }
            

}


}


}