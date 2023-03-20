


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectsAddedMessage : Dofus2Message
{

public const uint Id = 2889;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] @object;
        

public ObjectsAddedMessage()
{
}

public ObjectsAddedMessage(Types.ObjectItem[] @object)
        {
            this.@object = @object;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)@object.Length);
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 @object[i] = new Types.ObjectItem();
                 @object[i].Deserialize(reader);
            }
            

}


}


}