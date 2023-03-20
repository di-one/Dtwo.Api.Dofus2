


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightSynchronizeMessage : Dofus2Message
{

public const uint Id = 7636;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightFighterInformations[] fighters;
        

public GameFightSynchronizeMessage()
{
}

public GameFightSynchronizeMessage(Types.GameFightFighterInformations[] fighters)
        {
            this.fighters = fighters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)fighters.Length);
            foreach (var entry in fighters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            fighters = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 fighters[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
                 fighters[i].Deserialize(reader);
            }
            

}


}


}