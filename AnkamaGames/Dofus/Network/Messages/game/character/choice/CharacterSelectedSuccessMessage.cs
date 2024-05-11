


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CharacterSelectedSuccessMessage : Dofus2Message
{

public const uint Id = 2529;
public override uint MessageId
{
    get { return Id; }
}

public Types.CharacterBaseInformations infos;
        public bool isCollectingStats;
        

public CharacterSelectedSuccessMessage()
{
}

public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos, bool isCollectingStats)
        {
            this.infos = infos;
            this.isCollectingStats = isCollectingStats;
        }
        

public override void Serialize(IDataWriter writer)
{

infos.Serialize(writer);
            writer.WriteBoolean(isCollectingStats);
            

}

public override void Deserialize(IDataReader reader)
{

infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
            isCollectingStats = reader.ReadBoolean();
            

}


}


}