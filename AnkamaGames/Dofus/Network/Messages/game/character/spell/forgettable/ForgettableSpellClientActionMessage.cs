


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ForgettableSpellClientActionMessage : Dofus2Message
{

public const uint Id = 2288;
public override uint MessageId
{
    get { return Id; }
}

public int spellId;
        public sbyte action;
        

public ForgettableSpellClientActionMessage()
{
}

public ForgettableSpellClientActionMessage(int spellId, sbyte action)
        {
            this.spellId = spellId;
            this.action = action;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(spellId);
            writer.WriteSbyte(action);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadInt();
            action = reader.ReadSbyte();
            

}


}


}