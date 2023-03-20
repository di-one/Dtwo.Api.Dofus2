


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildUpdateNoteMessage : Dofus2Message
{

public const uint Id = 3003;
public override uint MessageId
{
    get { return Id; }
}

public double memberId;
        public string note;
        

public GuildUpdateNoteMessage()
{
}

public GuildUpdateNoteMessage(double memberId, string note)
        {
            this.memberId = memberId;
            this.note = note;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarLong(memberId);
            writer.WriteUTF(note);
            

}

public override void Deserialize(IDataReader reader)
{

memberId = reader.ReadVarUhLong();
            note = reader.ReadUTF();
            

}


}


}