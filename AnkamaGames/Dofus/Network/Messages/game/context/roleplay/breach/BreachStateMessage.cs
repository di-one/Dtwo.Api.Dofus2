


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachStateMessage : Dofus2Message
{

public const uint Id = 6068;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations owner;
        public Types.ObjectEffectInteger[] bonuses;
        public uint bugdet;
        public bool saved;
        

public BreachStateMessage()
{
}

public BreachStateMessage(Types.CharacterMinimalInformations owner, Types.ObjectEffectInteger[] bonuses, uint bugdet, bool saved)
        {
            this.owner = owner;
            this.bonuses = bonuses;
            this.bugdet = bugdet;
            this.saved = saved;
        }
        

public override void Serialize(IDataWriter writer)
{

owner.Serialize(writer);
            writer.WriteShort((short)bonuses.Length);
            foreach (var entry in bonuses)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)bugdet);
            writer.WriteBoolean(saved);
            

}

public override void Deserialize(IDataReader reader)
{

owner = new Types.CharacterMinimalInformations();
            owner.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            bonuses = new Types.ObjectEffectInteger[limit];
            for (int i = 0; i < limit; i++)
            {
                 bonuses[i] = new Types.ObjectEffectInteger();
                 bonuses[i].Deserialize(reader);
            }
            bugdet = reader.ReadVarUhInt();
            saved = reader.ReadBoolean();
            

}


}


}