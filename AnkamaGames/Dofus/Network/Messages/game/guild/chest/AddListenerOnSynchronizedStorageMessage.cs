


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AddListenerOnSynchronizedStorageMessage : Dofus2Message
{

public const uint Id = 4633;
public override uint MessageId
{
    get { return Id; }
}

public string player;
        

public AddListenerOnSynchronizedStorageMessage()
{
}

public AddListenerOnSynchronizedStorageMessage(string player)
        {
            this.player = player;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(player);
            

}

public override void Deserialize(IDataReader reader)
{

player = reader.ReadUTF();
            

}


}


}