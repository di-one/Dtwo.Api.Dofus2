


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ObjectAddedMessage : Dofus2Message
{

public const uint Id = 3844;
public override uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem @object;
        public sbyte origin;
        

public ObjectAddedMessage()
{
}

public ObjectAddedMessage(Types.ObjectItem @object, sbyte origin)
        {
            this.@object = @object;
            this.origin = origin;
        }
        

public override void Serialize(IDataWriter writer)
{

@object.Serialize(writer);
            writer.WriteSbyte(origin);
            

}

public override void Deserialize(IDataReader reader)
{

@object = new Types.ObjectItem();
            @object.Deserialize(reader);
            origin = reader.ReadSbyte();
            

}


}


}