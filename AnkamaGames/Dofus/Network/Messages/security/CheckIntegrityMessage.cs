


















// Generated on 01/22/2023 17:43:01
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CheckIntegrityMessage : Dofus2Message
{

public const uint Id = 643;
public override uint MessageId
{
    get { return Id; }
}

public sbyte[] data;
        

public CheckIntegrityMessage()
{
}

public CheckIntegrityMessage(sbyte[] data)
        {
            this.data = data;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)(ushort)data.Length);
            foreach (var entry in data)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadVarInt();
            data = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 data[i] = reader.ReadSbyte();
            }
            

}


}


}