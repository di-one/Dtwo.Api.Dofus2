


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightStartMessage : Dofus2Message
{

public const uint Id = 3034;
public override uint MessageId
{
    get { return Id; }
}

public Types.Idol[] idols;
        

public GameFightStartMessage()
{
}

public GameFightStartMessage(Types.Idol[] idols)
        {
            this.idols = idols;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)idols.Length);
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 idols[i] = new Types.Idol();
                 idols[i].Deserialize(reader);
            }
            

}


}


}