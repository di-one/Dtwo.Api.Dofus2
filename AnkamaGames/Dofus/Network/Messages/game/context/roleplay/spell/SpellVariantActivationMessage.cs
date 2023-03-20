


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SpellVariantActivationMessage : Dofus2Message
{

public const uint Id = 3481;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        public bool result;
        

public SpellVariantActivationMessage()
{
}

public SpellVariantActivationMessage(uint spellId, bool result)
        {
            this.spellId = spellId;
            this.result = result;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            writer.WriteBoolean(result);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            result = reader.ReadBoolean();
            

}


}


}