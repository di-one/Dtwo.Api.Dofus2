


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class TaxCollectorMovement
{

public const short Id = 7076;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public double playerId;
        public string playerName;
        

public TaxCollectorMovement()
{
}

public TaxCollectorMovement(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSbyte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            

}

public virtual void Deserialize(IDataReader reader)
{

movementType = reader.ReadSbyte();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            

}


}


}