


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MigratedServerListMessage : Dofus2Message
{

public const uint Id = 8658;
public override uint MessageId
{
    get { return Id; }
}

public uint[] migratedServerIds;
        

public MigratedServerListMessage()
{
}

public MigratedServerListMessage(uint[] migratedServerIds)
        {
            this.migratedServerIds = migratedServerIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)migratedServerIds.Length);
            foreach (var entry in migratedServerIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            migratedServerIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 migratedServerIds[i] = reader.ReadVarUhShort();
            }
            

}


}


}