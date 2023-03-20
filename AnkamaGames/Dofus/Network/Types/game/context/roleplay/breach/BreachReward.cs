


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class BreachReward
{

public const short Id = 1621;
public virtual short TypeId
{
    get { return Id; }
}

public uint id;
        public sbyte[] buyLocks;
        public string buyCriterion;
        public int remainingQty;
        public uint price;
        

public BreachReward()
{
}

public BreachReward(uint id, sbyte[] buyLocks, string buyCriterion, int remainingQty, uint price)
        {
            this.id = id;
            this.buyLocks = buyLocks;
            this.buyCriterion = buyCriterion;
            this.remainingQty = remainingQty;
            this.price = price;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)id);
            writer.WriteVarInt((int)(ushort)buyLocks.Length);
            foreach (var entry in buyLocks)
            {
                 writer.WriteSbyte(entry);
            }
            writer.WriteUTF(buyCriterion);
            writer.WriteVarInt((int)remainingQty);
            writer.WriteVarInt((int)price);
            

}

public virtual void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhInt();
            var limit = (ushort)reader.ReadVarInt();
            buyLocks = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 buyLocks[i] = reader.ReadSbyte();
            }
            buyCriterion = reader.ReadUTF();
            remainingQty = reader.ReadVarInt();
            price = reader.ReadVarUhInt();
            

}


}


}