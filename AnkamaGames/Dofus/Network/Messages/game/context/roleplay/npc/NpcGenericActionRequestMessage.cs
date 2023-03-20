


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class NpcGenericActionRequestMessage : Dofus2Message
{

public const uint Id = 8628;
public override uint MessageId
{
    get { return Id; }
}

public int npcId;
        public sbyte npcActionId;
        public double npcMapId;
        

public NpcGenericActionRequestMessage()
{
}

public NpcGenericActionRequestMessage(int npcId, sbyte npcActionId, double npcMapId)
        {
            this.npcId = npcId;
            this.npcActionId = npcActionId;
            this.npcMapId = npcMapId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(npcId);
            writer.WriteSbyte(npcActionId);
            writer.WriteDouble(npcMapId);
            

}

public override void Deserialize(IDataReader reader)
{

npcId = reader.ReadInt();
            npcActionId = reader.ReadSbyte();
            npcMapId = reader.ReadDouble();
            

}


}


}