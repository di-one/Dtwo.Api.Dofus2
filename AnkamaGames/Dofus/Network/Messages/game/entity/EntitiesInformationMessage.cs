


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class EntitiesInformationMessage : Dofus2Message
{

public const uint Id = 397;
public override uint MessageId
{
    get { return Id; }
}

public Types.EntityInformation[] entities;
        

public EntitiesInformationMessage()
{
}

public EntitiesInformationMessage(Types.EntityInformation[] entities)
        {
            this.entities = entities;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)entities.Length);
            foreach (var entry in entities)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            entities = new Types.EntityInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 entities[i] = new Types.EntityInformation();
                 entities[i].Deserialize(reader);
            }
            

}


}


}