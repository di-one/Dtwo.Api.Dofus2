


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagPackListMessage : Dofus2Message
{

public const uint Id = 112;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] packIds;
        

public HavenBagPackListMessage()
{
}

public HavenBagPackListMessage(sbyte[] packIds)
        {
            this.packIds = packIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)packIds.Length);
            foreach (var entry in packIds)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 packIds[i] = reader.ReadSbyte();
            }
            

}


}


}