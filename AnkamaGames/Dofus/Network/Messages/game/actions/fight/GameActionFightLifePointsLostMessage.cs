


















// Generated on 01/22/2023 17:42:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightLifePointsLostMessage : AbstractGameActionMessage
{

public const uint Id = 1167;
public override uint MessageId
{
    get { return Id; }
}

public double targetId;
        public uint loss;
        public uint permanentDamages;
        public int elementId;
        

public GameActionFightLifePointsLostMessage()
{
}

public GameActionFightLifePointsLostMessage(uint actionId, double sourceId, double targetId, uint loss, uint permanentDamages, int elementId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.loss = loss;
            this.permanentDamages = permanentDamages;
            this.elementId = elementId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)loss);
            writer.WriteVarInt((int)permanentDamages);
            writer.WriteVarInt((int)elementId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            loss = reader.ReadVarUhInt();
            permanentDamages = reader.ReadVarUhInt();
            elementId = reader.ReadVarInt();
            

}


}


}