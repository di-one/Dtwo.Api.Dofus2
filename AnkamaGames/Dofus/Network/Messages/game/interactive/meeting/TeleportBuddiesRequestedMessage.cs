


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TeleportBuddiesRequestedMessage : Dofus2Message
{

public const uint Id = 7211;
public override uint MessageId
{
    get { return Id; }
}

public uint dungeonId;
        public double inviterId;
        public double[] invalidBuddiesIds;
        

public TeleportBuddiesRequestedMessage()
{
}

public TeleportBuddiesRequestedMessage(uint dungeonId, double inviterId, double[] invalidBuddiesIds)
        {
            this.dungeonId = dungeonId;
            this.inviterId = inviterId;
            this.invalidBuddiesIds = invalidBuddiesIds;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(inviterId);
            writer.WriteShort((short)invalidBuddiesIds.Length);
            foreach (var entry in invalidBuddiesIds)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

dungeonId = reader.ReadVarUhShort();
            inviterId = reader.ReadVarUhLong();
            var limit = (ushort)reader.ReadUShort();
            invalidBuddiesIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 invalidBuddiesIds[i] = reader.ReadVarUhLong();
            }
            

}


}


}