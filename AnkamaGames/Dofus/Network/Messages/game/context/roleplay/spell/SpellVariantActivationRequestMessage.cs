


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SpellVariantActivationRequestMessage : Dofus2Message
{

public const uint Id = 8977;
public override uint MessageId
{
    get { return Id; }
}

public uint spellId;
        

public SpellVariantActivationRequestMessage()
{
}

public SpellVariantActivationRequestMessage(uint spellId)
        {
            this.spellId = spellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)spellId);
            

}

public override void Deserialize(IDataReader reader)
{

spellId = reader.ReadVarUhShort();
            

}


}


}