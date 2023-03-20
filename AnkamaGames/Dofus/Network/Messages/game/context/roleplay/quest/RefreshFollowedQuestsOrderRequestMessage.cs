


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class RefreshFollowedQuestsOrderRequestMessage : Dofus2Message
{

public const uint Id = 5420;
public override uint MessageId
{
    get { return Id; }
}

public uint[] quests;
        

public RefreshFollowedQuestsOrderRequestMessage()
{
}

public RefreshFollowedQuestsOrderRequestMessage(uint[] quests)
        {
            this.quests = quests;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)quests.Length);
            foreach (var entry in quests)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            quests = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 quests[i] = reader.ReadVarUhShort();
            }
            

}


}


}