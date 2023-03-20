


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeMountsStableRemoveMessage : Dofus2Message
{

public const uint Id = 5321;
public override uint MessageId
{
    get { return Id; }
}

public int[] mountsId;
        

public ExchangeMountsStableRemoveMessage()
{
}

public ExchangeMountsStableRemoveMessage(int[] mountsId)
        {
            this.mountsId = mountsId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)mountsId.Length);
            foreach (var entry in mountsId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            mountsId = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 mountsId[i] = reader.ReadVarInt();
            }
            

}


}


}