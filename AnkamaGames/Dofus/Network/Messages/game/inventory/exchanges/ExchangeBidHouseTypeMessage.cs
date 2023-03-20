


















// Generated on 01/22/2023 17:42:56
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseTypeMessage : Dofus2Message
{

public const uint Id = 2561;
public override uint MessageId
{
    get { return Id; }
}

public uint type;
        public bool follow;
        

public ExchangeBidHouseTypeMessage()
{
}

public ExchangeBidHouseTypeMessage(uint type, bool follow)
        {
            this.type = type;
            this.follow = follow;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)type);
            writer.WriteBoolean(follow);
            

}

public override void Deserialize(IDataReader reader)
{

type = reader.ReadVarUhInt();
            follow = reader.ReadBoolean();
            

}


}


}