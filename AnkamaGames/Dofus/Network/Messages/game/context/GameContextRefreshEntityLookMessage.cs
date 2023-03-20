


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameContextRefreshEntityLookMessage : Dofus2Message
{

public const uint Id = 3848;
public override uint MessageId
{
    get { return Id; }
}

public double id;
        public Types.EntityLook look;
        

public GameContextRefreshEntityLookMessage()
{
}

public GameContextRefreshEntityLookMessage(double id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(id);
            look.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

id = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
            

}


}


}