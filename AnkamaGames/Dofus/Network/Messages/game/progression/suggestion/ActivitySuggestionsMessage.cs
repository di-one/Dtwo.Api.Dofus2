


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ActivitySuggestionsMessage : Dofus2Message
{

public const uint Id = 2157;
public override uint MessageId
{
    get { return Id; }
}

public uint[] lockedActivitiesIds;
        public uint[] unlockedActivitiesIds;
        

public ActivitySuggestionsMessage()
{
}

public ActivitySuggestionsMessage(uint[] lockedActivitiesIds, uint[] unlockedActivitiesIds)
        {
            this.lockedActivitiesIds = lockedActivitiesIds;
            this.unlockedActivitiesIds = unlockedActivitiesIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)lockedActivitiesIds.Length);
            foreach (var entry in lockedActivitiesIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)unlockedActivitiesIds.Length);
            foreach (var entry in unlockedActivitiesIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            lockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 lockedActivitiesIds[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            unlockedActivitiesIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlockedActivitiesIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}