


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayShowMultipleActorsMessage : Dofus2Message
{

public const uint Id = 7171;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameRolePlayActorInformations[] informationsList;
        

public GameRolePlayShowMultipleActorsMessage()
{
}

public GameRolePlayShowMultipleActorsMessage(Types.GameRolePlayActorInformations[] informationsList)
        {
            this.informationsList = informationsList;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)informationsList.Length);
            foreach (var entry in informationsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            informationsList = new Types.GameRolePlayActorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 informationsList[i] = ProtocolTypeManager.GetInstance<Types.GameRolePlayActorInformations>(reader.ReadUShort());
                 informationsList[i].Deserialize(reader);
            }
            

}


}


}