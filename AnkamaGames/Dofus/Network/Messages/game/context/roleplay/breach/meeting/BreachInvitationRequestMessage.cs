


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachInvitationRequestMessage : Dofus2Message
{

public const uint Id = 8081;
public override uint MessageId
{
    get { return Id; }
}

public double[] guests;
        

public BreachInvitationRequestMessage()
{
}

public BreachInvitationRequestMessage(double[] guests)
        {
            this.guests = guests;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)guests.Length);
            foreach (var entry in guests)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            guests = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 guests[i] = reader.ReadVarUhLong();
            }
            

}


}


}