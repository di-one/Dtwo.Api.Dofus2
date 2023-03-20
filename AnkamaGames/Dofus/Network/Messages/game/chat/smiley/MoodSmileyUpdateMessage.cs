


















// Generated on 01/22/2023 17:42:42
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class MoodSmileyUpdateMessage : Dofus2Message
{

public const uint Id = 2215;
public override uint MessageId
{
    get { return Id; }
}

public int accountId;
        public double playerId;
        public uint smileyId;
        

public MoodSmileyUpdateMessage()
{
}

public MoodSmileyUpdateMessage(int accountId, double playerId, uint smileyId)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.smileyId = smileyId;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteVarShort((int)smileyId);
            

}

public override void Deserialize(IDataReader reader)
{

accountId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
            smileyId = reader.ReadVarUhShort();
            

}


}


}