


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StartupActionsObjetAttributionMessage : Dofus2Message
{

public const uint Id = 2128;
public override uint MessageId
{
    get { return Id; }
}

public int actionId;
        public double characterId;
        

public StartupActionsObjetAttributionMessage()
{
}

public StartupActionsObjetAttributionMessage(int actionId, double characterId)
        {
            this.actionId = actionId;
            this.characterId = characterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(actionId);
            writer.WriteVarLong(characterId);
            

}

public override void Deserialize(IDataReader reader)
{

actionId = reader.ReadInt();
            characterId = reader.ReadVarUhLong();
            

}


}


}