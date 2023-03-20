


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class DungeonPartyFinderPlayer
{

public const short Id = 3739;
public virtual short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public uint level;
        

public DungeonPartyFinderPlayer()
{
}

public DungeonPartyFinderPlayer(double playerId, string playerName, sbyte breed, bool sex, uint level)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)level);
            

}

public virtual void Deserialize(IDataReader reader)
{

playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            level = reader.ReadVarUhShort();
            

}


}


}