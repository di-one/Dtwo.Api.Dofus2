


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismFightAttackerAddMessage : Dofus2Message
{

public const uint Id = 4390;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public Types.CharacterMinimalPlusLookInformations attacker;
        

public PrismFightAttackerAddMessage()
{
}

public PrismFightAttackerAddMessage(uint subAreaId, uint fightId, Types.CharacterMinimalPlusLookInformations attacker)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.attacker = attacker;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteShort(attacker.TypeId);
            attacker.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            attacker = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            attacker.Deserialize(reader);
            

}


}


}