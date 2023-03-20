


















// Generated on 01/22/2023 17:42:52
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class SpouseInformationsMessage : Dofus2Message
{

public const uint Id = 4709;
public override uint MessageId
{
    get { return Id; }
}

public Types.FriendSpouseInformations spouse;
        

public SpouseInformationsMessage()
{
}

public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

spouse = ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadUShort());
            spouse.Deserialize(reader);
            

}


}


}