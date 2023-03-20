


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameContextRemoveMultipleElementsMessage : Dofus2Message
{

public const uint Id = 3246;
public override uint MessageId
{
    get { return Id; }
}

public double[] elementsIds;
        

public GameContextRemoveMultipleElementsMessage()
{
}

public GameContextRemoveMultipleElementsMessage(double[] elementsIds)
        {
            this.elementsIds = elementsIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)elementsIds.Length);
            foreach (var entry in elementsIds)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            elementsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 elementsIds[i] = reader.ReadDouble();
            }
            

}


}


}