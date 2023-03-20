


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseInListAddedMessage : Dofus2Message
{

public const uint Id = 4304;
public override uint MessageId
{
    get { return Id; }
}

public int itemUID;
        public uint objectGID;
        public int objectType;
        public Types.ObjectEffect[] effects;
        public double[] prices;
        

public ExchangeBidHouseInListAddedMessage()
{
}

public ExchangeBidHouseInListAddedMessage(int itemUID, uint objectGID, int objectType, Types.ObjectEffect[] effects, double[] prices)
        {
            this.itemUID = itemUID;
            this.objectGID = objectGID;
            this.objectType = objectType;
            this.effects = effects;
            this.prices = prices;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(itemUID);
            writer.WriteVarInt((int)objectGID);
            writer.WriteInt(objectType);
            writer.WriteShort((short)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)prices.Length);
            foreach (var entry in prices)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

itemUID = reader.ReadInt();
            objectGID = reader.ReadVarUhInt();
            objectType = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            prices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 prices[i] = reader.ReadVarUhLong();
            }
            

}


}


}