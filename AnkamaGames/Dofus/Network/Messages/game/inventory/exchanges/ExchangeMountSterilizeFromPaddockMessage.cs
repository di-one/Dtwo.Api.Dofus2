


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeMountSterilizeFromPaddockMessage : Dofus2Message
{

public const uint Id = 8315;
public override uint MessageId
{
    get { return Id; }
}

public string name;
        public short worldX;
        public short worldY;
        public string sterilizator;
        

public ExchangeMountSterilizeFromPaddockMessage()
{
}

public ExchangeMountSterilizeFromPaddockMessage(string name, short worldX, short worldY, string sterilizator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.sterilizator = sterilizator;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(sterilizator);
            

}

public override void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            sterilizator = reader.ReadUTF();
            

}


}


}