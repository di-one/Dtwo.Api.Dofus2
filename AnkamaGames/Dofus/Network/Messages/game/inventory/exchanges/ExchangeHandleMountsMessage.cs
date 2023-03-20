


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeHandleMountsMessage : Dofus2Message
{

public const uint Id = 3191;
public override uint MessageId
{
    get { return Id; }
}

public sbyte actionType;
        public uint[] ridesId;
        

public ExchangeHandleMountsMessage()
{
}

public ExchangeHandleMountsMessage(sbyte actionType, uint[] ridesId)
        {
            this.actionType = actionType;
            this.ridesId = ridesId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(actionType);
            writer.WriteShort((short)ridesId.Length);
            foreach (var entry in ridesId)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

actionType = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            ridesId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ridesId[i] = reader.ReadVarUhInt();
            }
            

}


}


}