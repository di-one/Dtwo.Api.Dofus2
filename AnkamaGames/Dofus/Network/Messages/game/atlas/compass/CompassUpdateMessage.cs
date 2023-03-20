


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class CompassUpdateMessage : Dofus2Message
{

public const uint Id = 7989;
public override uint MessageId
{
    get { return Id; }
}

public sbyte type;
        public Types.MapCoordinates coords;
        

public CompassUpdateMessage()
{
}

public CompassUpdateMessage(sbyte type, Types.MapCoordinates coords)
        {
            this.type = type;
            this.coords = coords;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(type);
            writer.WriteShort(coords.TypeId);
            coords.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadSbyte();
            coords = ProtocolTypeManager.GetInstance<Types.MapCoordinates>(reader.ReadUShort());
            coords.Deserialize(reader);
            

}


}


}