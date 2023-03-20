


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagRoomUpdateMessage : Dofus2Message
{

public const uint Id = 9197;
public override uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.HavenBagRoomPreviewInformation[] roomsPreview;
        

public HavenBagRoomUpdateMessage()
{
}

public HavenBagRoomUpdateMessage(sbyte action, Types.HavenBagRoomPreviewInformation[] roomsPreview)
        {
            this.action = action;
            this.roomsPreview = roomsPreview;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)roomsPreview.Length);
            foreach (var entry in roomsPreview)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            roomsPreview = new Types.HavenBagRoomPreviewInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 roomsPreview[i] = new Types.HavenBagRoomPreviewInformation();
                 roomsPreview[i].Deserialize(reader);
            }
            

}


}


}