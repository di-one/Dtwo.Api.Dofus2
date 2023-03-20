


















// Generated on 01/22/2023 17:42:44
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameDataPaddockObjectListAddMessage : Dofus2Message
{

public const uint Id = 2147;
public override uint MessageId
{
    get { return Id; }
}

public Types.PaddockItem[] paddockItemDescription;
        

public GameDataPaddockObjectListAddMessage()
{
}

public GameDataPaddockObjectListAddMessage(Types.PaddockItem[] paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)paddockItemDescription.Length);
            foreach (var entry in paddockItemDescription)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            paddockItemDescription = new Types.PaddockItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddockItemDescription[i] = new Types.PaddockItem();
                 paddockItemDescription[i].Deserialize(reader);
            }
            

}


}


}