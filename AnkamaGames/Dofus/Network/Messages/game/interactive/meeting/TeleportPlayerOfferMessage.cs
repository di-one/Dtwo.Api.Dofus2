


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportPlayerOfferMessage : Dofus2Message
{

public const uint Id = 7570;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public string message;
        public uint timeLeft;
        public double requesterId;
        

public TeleportPlayerOfferMessage()
{
}

public TeleportPlayerOfferMessage(double mapId, string message, uint timeLeft, double requesterId)
        {
            this.mapId = mapId;
            this.message = message;
            this.timeLeft = timeLeft;
            this.requesterId = requesterId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteUTF(message);
            writer.WriteVarInt((int)timeLeft);
            writer.WriteVarLong(requesterId);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            message = reader.ReadUTF();
            timeLeft = reader.ReadVarUhInt();
            requesterId = reader.ReadVarUhLong();
            

}


}


}