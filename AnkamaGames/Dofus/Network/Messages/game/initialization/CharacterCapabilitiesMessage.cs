


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterCapabilitiesMessage : Dofus2Message
{

public const uint Id = 6638;
public override uint MessageId
{
    get { return Id; }
}

public uint guildEmblemSymbolCategories;
        

public CharacterCapabilitiesMessage()
{
}

public CharacterCapabilitiesMessage(uint guildEmblemSymbolCategories)
        {
            this.guildEmblemSymbolCategories = guildEmblemSymbolCategories;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)guildEmblemSymbolCategories);
            

}

public override void Deserialize(IDataReader reader)
{

guildEmblemSymbolCategories = reader.ReadVarUhInt();
            

}


}


}