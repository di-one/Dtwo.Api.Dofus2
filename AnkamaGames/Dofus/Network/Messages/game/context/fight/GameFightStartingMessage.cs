


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightStartingMessage : Dofus2Message
{

public const uint Id = 4026;
public override uint MessageId
{
    get { return Id; }
}

public sbyte fightType;
        public uint fightId;
        public double attackerId;
        public double defenderId;
        public bool containsBoss;
        public int[] monsters;
        

public GameFightStartingMessage()
{
}

public GameFightStartingMessage(sbyte fightType, uint fightId, double attackerId, double defenderId, bool containsBoss, int[] monsters)
        {
            this.fightType = fightType;
            this.fightId = fightId;
            this.attackerId = attackerId;
            this.defenderId = defenderId;
            this.containsBoss = containsBoss;
            this.monsters = monsters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(fightType);
            writer.WriteVarShort((int)fightId);
            writer.WriteDouble(attackerId);
            writer.WriteDouble(defenderId);
            writer.WriteBoolean(containsBoss);
            writer.WriteShort((short)monsters.Length);
            foreach (var entry in monsters)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

fightType = reader.ReadSbyte();
            fightId = reader.ReadVarUhShort();
            attackerId = reader.ReadDouble();
            defenderId = reader.ReadDouble();
            containsBoss = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            monsters = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsters[i] = reader.ReadInt();
            }
            

}


}


}