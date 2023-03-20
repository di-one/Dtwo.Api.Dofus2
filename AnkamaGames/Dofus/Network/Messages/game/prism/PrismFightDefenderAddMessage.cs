


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismFightDefenderAddMessage : Dofus2Message
{

public const uint Id = 2845;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public Types.CharacterMinimalPlusLookInformations defender;
        

public PrismFightDefenderAddMessage()
{
}

public PrismFightDefenderAddMessage(uint subAreaId, uint fightId, Types.CharacterMinimalPlusLookInformations defender)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.defender = defender;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteShort(defender.TypeId);
            defender.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            defender = ProtocolTypeManager.GetInstance<Types.CharacterMinimalPlusLookInformations>(reader.ReadUShort());
            defender.Deserialize(reader);
            

}


}


}