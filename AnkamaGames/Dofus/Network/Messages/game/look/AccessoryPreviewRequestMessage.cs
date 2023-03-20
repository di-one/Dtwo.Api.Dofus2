


















// Generated on 01/22/2023 17:42:59
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AccessoryPreviewRequestMessage : Dofus2Message
{

public const uint Id = 7170;
public override uint MessageId
{
    get { return Id; }
}

public uint[] genericId;
        

public AccessoryPreviewRequestMessage()
{
}

public AccessoryPreviewRequestMessage(uint[] genericId)
        {
            this.genericId = genericId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)genericId.Length);
            foreach (var entry in genericId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            genericId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 genericId[i] = reader.ReadVarUhInt();
            }
            

}


}


}