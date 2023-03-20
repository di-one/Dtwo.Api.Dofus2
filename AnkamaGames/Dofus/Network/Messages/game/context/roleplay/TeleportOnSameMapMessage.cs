


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportOnSameMapMessage : Dofus2Message
{

public const uint Id = 8386;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint cellId;
        

public TeleportOnSameMapMessage()
{
}

public TeleportOnSameMapMessage(double targetId, uint cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(targetId);
            writer.WriteVarShort((int)cellId);
            

}

public override void Deserialize(IDataReader reader)
{

targetId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
            

}


}


}