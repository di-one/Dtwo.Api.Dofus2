


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlterationsUpdatedMessage : Dofus2Message
{

public const uint Id = 1460;
public override uint MessageId
{
    get { return Id; }
}

public Types.AlterationInfo[] alterations;
        

public AlterationsUpdatedMessage()
{
}

public AlterationsUpdatedMessage(Types.AlterationInfo[] alterations)
        {
            this.alterations = alterations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)alterations.Length);
            foreach (var entry in alterations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            alterations = new Types.AlterationInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 alterations[i] = new Types.AlterationInfo();
                 alterations[i].Deserialize(reader);
            }
            

}


}


}