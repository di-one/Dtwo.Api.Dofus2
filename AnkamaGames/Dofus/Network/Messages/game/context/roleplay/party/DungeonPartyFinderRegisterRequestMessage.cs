


















// Generated on 01/22/2023 17:42:49
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DungeonPartyFinderRegisterRequestMessage : Dofus2Message
{

public const uint Id = 1894;
public override uint MessageId
{
    get { return Id; }
}

public uint[] dungeonIds;
        

public DungeonPartyFinderRegisterRequestMessage()
{
}

public DungeonPartyFinderRegisterRequestMessage(uint[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            dungeonIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}