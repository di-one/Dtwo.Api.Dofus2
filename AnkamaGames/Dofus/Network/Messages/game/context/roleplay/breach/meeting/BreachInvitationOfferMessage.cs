


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachInvitationOfferMessage : Dofus2Message
{

public const uint Id = 7487;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations host;
        public uint timeLeftBeforeCancel;
        

public BreachInvitationOfferMessage()
{
}

public BreachInvitationOfferMessage(Types.CharacterMinimalInformations host, uint timeLeftBeforeCancel)
        {
            this.host = host;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        

public override void Serialize(IDataWriter writer)
{

host.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
            

}

public override void Deserialize(IDataReader reader)
{

host = new Types.CharacterMinimalInformations();
            host.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarUhInt();
            

}


}


}