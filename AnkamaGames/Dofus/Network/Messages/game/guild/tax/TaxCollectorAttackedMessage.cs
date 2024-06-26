


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TaxCollectorAttackedMessage : Dofus2Message
{

public const uint Id = 9963;
public override uint MessageId
{
    get { return Id; }
}

public uint firstNameId;
        public uint lastNameId;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        public Types.BasicGuildInformations guild;
        

public TaxCollectorAttackedMessage()
{
}

public TaxCollectorAttackedMessage(uint firstNameId, uint lastNameId, short worldX, short worldY, double mapId, uint subAreaId, Types.BasicGuildInformations guild)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.guild = guild;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            guild.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
            

}


}


}