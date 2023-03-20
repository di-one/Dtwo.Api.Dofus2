


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PrismFightDefenderLeaveMessage : Dofus2Message
{

public const uint Id = 212;
public override uint MessageId
{
    get { return Id; }
}

public uint subAreaId;
        public uint fightId;
        public double fighterToRemoveId;
        

public PrismFightDefenderLeaveMessage()
{
}

public PrismFightDefenderLeaveMessage(uint subAreaId, uint fightId, double fighterToRemoveId)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterToRemoveId = fighterToRemoveId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(fighterToRemoveId);
            

}

public override void Deserialize(IDataReader reader)
{

subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            fighterToRemoveId = reader.ReadVarUhLong();
            

}


}


}