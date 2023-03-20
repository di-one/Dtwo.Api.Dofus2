


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PortalDialogCreationMessage : NpcDialogCreationMessage
{

public const uint Id = 9706;
public override uint MessageId
{
    get { return Id; }
}

public int type;
        

public PortalDialogCreationMessage()
{
}

public PortalDialogCreationMessage(double mapId, int npcId, int type)
         : base(mapId, npcId)
        {
            this.type = type;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(type);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            type = reader.ReadInt();
            

}


}


}