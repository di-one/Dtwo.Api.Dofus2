


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ListenersOfSynchronizedStorageMessage : Dofus2Message
{

public const uint Id = 8286;
public override uint MessageId
{
    get { return Id; }
}

public string[] players;
        

public ListenersOfSynchronizedStorageMessage()
{
}

public ListenersOfSynchronizedStorageMessage(string[] players)
        {
            this.players = players;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)players.Length);
            foreach (var entry in players)
            {
                 writer.WriteUTF(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            players = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 players[i] = reader.ReadUTF();
            }
            

}


}


}