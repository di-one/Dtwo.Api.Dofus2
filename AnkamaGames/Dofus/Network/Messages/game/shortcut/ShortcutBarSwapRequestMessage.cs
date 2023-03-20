


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ShortcutBarSwapRequestMessage : Dofus2Message
{

public const uint Id = 5362;
public override uint MessageId
{
    get { return Id; }
}

public sbyte barType;
        public sbyte firstSlot;
        public sbyte secondSlot;
        

public ShortcutBarSwapRequestMessage()
{
}

public ShortcutBarSwapRequestMessage(sbyte barType, sbyte firstSlot, sbyte secondSlot)
        {
            this.barType = barType;
            this.firstSlot = firstSlot;
            this.secondSlot = secondSlot;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(barType);
            writer.WriteSbyte(firstSlot);
            writer.WriteSbyte(secondSlot);
            

}

public override void Deserialize(IDataReader reader)
{

barType = reader.ReadSbyte();
            firstSlot = reader.ReadSbyte();
            secondSlot = reader.ReadSbyte();
            

}


}


}