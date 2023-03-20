


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildListApplicationModifiedMessage : Dofus2Message
{

public const uint Id = 4960;
public override uint MessageId
{
    get { return Id; }
}

public Types.GuildApplicationInformation apply;
        public sbyte state;
        public double playerId;
        

public GuildListApplicationModifiedMessage()
{
}

public GuildListApplicationModifiedMessage(Types.GuildApplicationInformation apply, sbyte state, double playerId)
        {
            this.apply = apply;
            this.state = state;
            this.playerId = playerId;
        }
        

public override void Serialize(IDataWriter writer)
{

apply.Serialize(writer);
            writer.WriteSbyte(state);
            writer.WriteVarLong(playerId);
            

}

public override void Deserialize(IDataReader reader)
{

apply = new Types.GuildApplicationInformation();
            apply.Deserialize(reader);
            state = reader.ReadSbyte();
            playerId = reader.ReadVarUhLong();
            

}


}


}