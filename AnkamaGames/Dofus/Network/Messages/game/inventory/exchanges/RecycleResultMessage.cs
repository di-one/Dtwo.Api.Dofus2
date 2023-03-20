


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class RecycleResultMessage : Dofus2Message
{

public const uint Id = 9365;
public override uint MessageId
{
    get { return Id; }
}

public uint nuggetsForPrism;
        public uint nuggetsForPlayer;
        

public RecycleResultMessage()
{
}

public RecycleResultMessage(uint nuggetsForPrism, uint nuggetsForPlayer)
        {
            this.nuggetsForPrism = nuggetsForPrism;
            this.nuggetsForPlayer = nuggetsForPlayer;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)nuggetsForPrism);
            writer.WriteVarInt((int)nuggetsForPlayer);
            

}

public override void Deserialize(IDataReader reader)
{

nuggetsForPrism = reader.ReadVarUhInt();
            nuggetsForPlayer = reader.ReadVarUhInt();
            

}


}


}