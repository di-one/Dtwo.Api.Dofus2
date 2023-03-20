


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeTypesExchangerDescriptionForUserMessage : Dofus2Message
{

public const uint Id = 473;
public override uint MessageId
{
    get { return Id; }
}

public int objectType;
        public uint[] typeDescription;
        

public ExchangeTypesExchangerDescriptionForUserMessage()
{
}

public ExchangeTypesExchangerDescriptionForUserMessage(int objectType, uint[] typeDescription)
        {
            this.objectType = objectType;
            this.typeDescription = typeDescription;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(objectType);
            writer.WriteShort((short)typeDescription.Length);
            foreach (var entry in typeDescription)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            typeDescription = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 typeDescription[i] = reader.ReadVarUhInt();
            }
            

}


}


}