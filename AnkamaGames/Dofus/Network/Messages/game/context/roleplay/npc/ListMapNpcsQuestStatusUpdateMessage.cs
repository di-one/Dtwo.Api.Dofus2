


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ListMapNpcsQuestStatusUpdateMessage : Dofus2Message
{

public const uint Id = 2320;
public override uint MessageId
{
    get { return Id; }
}

public Types.MapNpcQuestInfo[] mapInfo;
        

public ListMapNpcsQuestStatusUpdateMessage()
{
}

public ListMapNpcsQuestStatusUpdateMessage(Types.MapNpcQuestInfo[] mapInfo)
        {
            this.mapInfo = mapInfo;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mapInfo.Length);
            foreach (var entry in mapInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mapInfo = new Types.MapNpcQuestInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 mapInfo[i] = new Types.MapNpcQuestInfo();
                 mapInfo[i].Deserialize(reader);
            }
            

}


}


}