


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportToBuddyOfferMessage : Dofus2Message
{

public const uint Id = 1620;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double buddyId;
        public uint timeLeft;
        

public TeleportToBuddyOfferMessage()
{
}

public TeleportToBuddyOfferMessage(uint dungeonId, double buddyId, uint timeLeft)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.timeLeft = timeLeft;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteVarInt((int)timeLeft);
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            timeLeft = reader.ReadVarUhInt();
            

}


}


}