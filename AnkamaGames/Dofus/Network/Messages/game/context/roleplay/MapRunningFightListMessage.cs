


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MapRunningFightListMessage : Dofus2Message
{

public const uint Id = 8912;
public override uint MessageId
{
    get { return Id; }
}

public Types.FightExternalInformations[] fights;
        

public MapRunningFightListMessage()
{
}

public MapRunningFightListMessage(Types.FightExternalInformations[] fights)
        {
            this.fights = fights;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)fights.Length);
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            fights = new Types.FightExternalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fights[i] = new Types.FightExternalInformations();
                 fights[i].Deserialize(reader);
            }
            

}


}


}