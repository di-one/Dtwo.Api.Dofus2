


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
{

public const uint Id = 4807;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        

public GameActionFightDispellSpellMessage()
{
}

public GameActionFightDispellSpellMessage(uint actionId, double sourceId, double targetId, bool verboseCast, uint spellId)
         : base(actionId, sourceId, targetId, verboseCast)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            

}


}


}