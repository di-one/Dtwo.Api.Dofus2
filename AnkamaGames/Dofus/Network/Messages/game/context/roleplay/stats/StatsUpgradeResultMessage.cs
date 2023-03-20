


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StatsUpgradeResultMessage : Dofus2Message
{

public const uint Id = 4816;
public override uint MessageId
{
    get { return Id; }
}

public sbyte result;
        public uint nbCharacBoost;
        

public StatsUpgradeResultMessage()
{
}

public StatsUpgradeResultMessage(sbyte result, uint nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(result);
            writer.WriteVarShort((int)nbCharacBoost);
            

}

public override void Deserialize(IDataReader reader)
{

result = reader.ReadSbyte();
            nbCharacBoost = reader.ReadVarUhShort();
            

}


}


}