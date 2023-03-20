


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GroupTeleportPlayerOfferMessage : Dofus2Message
{

public const uint Id = 3021;
public override uint MessageId
{
    get { return Id; }
}

public double mapId;
        public short worldX;
        public short worldY;
        public uint timeLeft;
        public double requesterId;
        public string requesterName;
        

public GroupTeleportPlayerOfferMessage()
{
}

public GroupTeleportPlayerOfferMessage(double mapId, short worldX, short worldY, uint timeLeft, double requesterId, string requesterName)
        {
            this.mapId = mapId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.timeLeft = timeLeft;
            this.requesterId = requesterId;
            this.requesterName = requesterName;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteDouble(mapId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarInt((int)timeLeft);
            writer.WriteVarLong(requesterId);
            writer.WriteUTF(requesterName);
            

}

public override void Deserialize(IDataReader reader)
{

mapId = reader.ReadDouble();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            timeLeft = reader.ReadVarUhInt();
            requesterId = reader.ReadVarUhLong();
            requesterName = reader.ReadUTF();
            

}


}


}