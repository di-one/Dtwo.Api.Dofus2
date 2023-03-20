


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StatedMapUpdateMessage : Dofus2Message
{

public const uint Id = 6977;
public override uint MessageId
{
    get { return Id; }
}

public Types.StatedElement[] statedElements;
        

public StatedMapUpdateMessage()
{
}

public StatedMapUpdateMessage(Types.StatedElement[] statedElements)
        {
            this.statedElements = statedElements;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)statedElements.Length);
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 statedElements[i] = new Types.StatedElement();
                 statedElements[i].Deserialize(reader);
            }
            

}


}


}