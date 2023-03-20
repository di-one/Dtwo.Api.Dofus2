


















// Generated on 01/22/2023 17:42:50
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyMemberInStandardFightMessage : AbstractPartyMemberInFightMessage
{

public const uint Id = 6098;
public override uint MessageId
{
    get { return Id; }
}

public Types.MapCoordinatesExtended fightMap;
        

public PartyMemberInStandardFightMessage()
{
}

public PartyMemberInStandardFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, uint fightId, int timeBeforeFightStart, Types.MapCoordinatesExtended fightMap)
         : base(partyId, reason, memberId, memberAccountId, memberName, fightId, timeBeforeFightStart)
        {
            this.fightMap = fightMap;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            fightMap.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            fightMap = new Types.MapCoordinatesExtended();
            fightMap.Deserialize(reader);
            

}


}


}