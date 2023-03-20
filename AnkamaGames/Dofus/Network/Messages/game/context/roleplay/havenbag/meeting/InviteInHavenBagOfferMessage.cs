


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class InviteInHavenBagOfferMessage : Dofus2Message
{

public const uint Id = 3354;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterMinimalInformations hostInformations;
        public int timeLeftBeforeCancel;
        

public InviteInHavenBagOfferMessage()
{
}

public InviteInHavenBagOfferMessage(Types.CharacterMinimalInformations hostInformations, int timeLeftBeforeCancel)
        {
            this.hostInformations = hostInformations;
            this.timeLeftBeforeCancel = timeLeftBeforeCancel;
        }
        

public override void Serialize(IDataWriter writer)
{

hostInformations.Serialize(writer);
            writer.WriteVarInt((int)timeLeftBeforeCancel);
            

}

public override void Deserialize(IDataReader reader)
{

hostInformations = new Types.CharacterMinimalInformations();
            hostInformations.Deserialize(reader);
            timeLeftBeforeCancel = reader.ReadVarInt();
            

}


}


}