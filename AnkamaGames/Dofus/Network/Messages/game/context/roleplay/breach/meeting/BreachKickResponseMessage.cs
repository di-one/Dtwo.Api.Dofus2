


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachKickResponseMessage : Dofus2Message
{

public const uint Id = 4950;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations target;
        public bool kicked;
        

public BreachKickResponseMessage()
{
}

public BreachKickResponseMessage(Types.CharacterMinimalInformations target, bool kicked)
        {
            this.target = target;
            this.kicked = kicked;
        }
        

public override void Serialize(IDataWriter writer)
{

target.Serialize(writer);
            writer.WriteBoolean(kicked);
            

}

public override void Deserialize(IDataReader reader)
{

target = new Types.CharacterMinimalInformations();
            target.Deserialize(reader);
            kicked = reader.ReadBoolean();
            

}


}


}