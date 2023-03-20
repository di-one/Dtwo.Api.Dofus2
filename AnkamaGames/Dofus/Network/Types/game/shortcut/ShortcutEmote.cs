


















// Generated on 01/22/2023 17:43:08
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class ShortcutEmote : Shortcut
{

public const short Id = 6747;
public override short TypeId
{
    get { return Id; }
}

public ushort emoteId;
        

public ShortcutEmote()
{
}

public ShortcutEmote(sbyte slot, ushort emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(emoteId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadUShort();
            

}


}


}