


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HavenBagRoomPreviewInformation
{

public const short Id = 4008;
public virtual short TypeId
{
    get { return Id; }
}

public byte roomId;
        public sbyte themeId;
        

public HavenBagRoomPreviewInformation()
{
}

public HavenBagRoomPreviewInformation(byte roomId, sbyte themeId)
        {
            this.roomId = roomId;
            this.themeId = themeId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteByte(roomId);
            writer.WriteSbyte(themeId);
            

}

public virtual void Deserialize(IDataReader reader)
{

roomId = reader.ReadByte();
            themeId = reader.ReadSbyte();
            

}


}


}