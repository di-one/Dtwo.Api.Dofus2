


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
{

public const uint Id = 6487;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        

public PartyInvitationDungeonRequestMessage()
{
}

public PartyInvitationDungeonRequestMessage(Types.AbstractPlayerSearchInformation target, uint dungeonId)
         : base(target)
        {
            this.dungeonId = dungeonId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
            

}


}


}