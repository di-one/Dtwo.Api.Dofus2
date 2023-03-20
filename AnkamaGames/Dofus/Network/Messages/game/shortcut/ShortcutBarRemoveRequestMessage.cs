


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ShortcutBarRemoveRequestMessage : Dofus2Message
{

public const uint Id = 5782;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public sbyte slot;
        

public ShortcutBarRemoveRequestMessage()
{
}

public ShortcutBarRemoveRequestMessage(sbyte barType, sbyte slot)
        {
            this.barType = barType;
            this.slot = slot;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteSbyte(slot);
            

}

public override void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            slot = reader.ReadSbyte();
            

}


}


}