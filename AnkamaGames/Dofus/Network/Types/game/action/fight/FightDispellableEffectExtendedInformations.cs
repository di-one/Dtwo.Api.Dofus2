


















// Generated on 01/22/2023 17:43:02
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FightDispellableEffectExtendedInformations
{

public const short Id = 5136;
public virtual short TypeId
{
    get { return Id; }
}

public uint actionId;
        public double sourceId;
        public Types.AbstractFightDispellableEffect effect;
        

public FightDispellableEffectExtendedInformations()
{
}

public FightDispellableEffectExtendedInformations(uint actionId, double sourceId, Types.AbstractFightDispellableEffect effect)
        {
            this.actionId = actionId;
            this.sourceId = sourceId;
            this.effect = effect;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)actionId);
            writer.WriteDouble(sourceId);
            writer.WriteShort(effect.TypeId);
            effect.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

actionId = reader.ReadVarUhShort();
            sourceId = reader.ReadDouble();
            effect = ProtocolTypeManager.GetInstance<Types.AbstractFightDispellableEffect>(reader.ReadUShort());
            effect.Deserialize(reader);
            

}


}


}