


















// Generated on 01/22/2023 17:42:55
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeBidHouseBuyResultMessage : Dofus2Message
{

public const uint Id = 5746;
public override uint MessageId
{
    get { return Id; }
}

public uint uid;
        public bool bought;
        

public ExchangeBidHouseBuyResultMessage()
{
}

public ExchangeBidHouseBuyResultMessage(uint uid, bool bought)
        {
            this.uid = uid;
            this.bought = bought;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)uid);
            writer.WriteBoolean(bought);
            

}

public override void Deserialize(IDataReader reader)
{

uid = reader.ReadVarUhInt();
            bought = reader.ReadBoolean();
            

}


}


}