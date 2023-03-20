


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NpcDialogCreationMessage : Dofus2Message
{

public const uint Id = 6164;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public int npcId;
        

public NpcDialogCreationMessage()
{
}

public NpcDialogCreationMessage(double mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteInt(npcId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            npcId = reader.ReadInt();
            

}


}


}