


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AbstractGameActionMessage : Dofus2Message
{

public const uint Id = 2888;
public override uint MessageId
{
    get { return Id; }
}

public uint actionId;
        public double sourceId;
        

public AbstractGameActionMessage()
{
}

public AbstractGameActionMessage(uint actionId, double sourceId)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            

}

public override void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            

}


}


}