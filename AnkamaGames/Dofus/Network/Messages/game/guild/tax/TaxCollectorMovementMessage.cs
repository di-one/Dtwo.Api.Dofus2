


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TaxCollectorMovementMessage : Dofus2Message
{

public const uint Id = 5589;
public override uint MessageId
{
    get { return Id; }
}

public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public double playerId;
        public string playerName;
        

public TaxCollectorMovementMessage()
{
}

public TaxCollectorMovementMessage(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            

}

public override void Deserialize(IDataReader reader)
{

movementType = reader.ReadSbyte();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            

}


}


}