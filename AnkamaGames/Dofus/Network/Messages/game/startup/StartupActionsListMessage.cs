


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StartupActionsListMessage : Dofus2Message
{

public const uint Id = 7819;
public override uint MessageId
{
    get { return Id; }
}

public Types.StartupActionAddObject[] actions;
        

public StartupActionsListMessage()
{
}

public StartupActionsListMessage(Types.StartupActionAddObject[] actions)
        {
            this.actions = actions;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)actions.Length);
            foreach (var entry in actions)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            actions = new Types.StartupActionAddObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 actions[i] = new Types.StartupActionAddObject();
                 actions[i].Deserialize(reader);
            }
            

}


}


}