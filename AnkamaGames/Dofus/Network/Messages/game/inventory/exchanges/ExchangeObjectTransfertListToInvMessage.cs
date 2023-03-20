


















// Generated on 01/22/2023 17:42:57
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeObjectTransfertListToInvMessage : Dofus2Message
{

public const uint Id = 6380;
public override uint MessageId
{
    get { return Id; }
}

public uint[] ids;
        

public ExchangeObjectTransfertListToInvMessage()
{
}

public ExchangeObjectTransfertListToInvMessage(uint[] ids)
        {
            this.ids = ids;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
            

}


}


}