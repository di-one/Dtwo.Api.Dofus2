


















// Generated on 01/22/2023 17:42:51
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class StatsUpgradeRequestMessage : Dofus2Message
{

public const uint Id = 7878;
public override uint MessageId
{
    get { return Id; }
}

public bool useAdditionnal;
        public sbyte statId;
        public uint boostPoint;
        

public StatsUpgradeRequestMessage()
{
}

public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, uint boostPoint)
        {
            this.useAdditionnal = useAdditionnal;
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteBoolean(useAdditionnal);
            writer.WriteSbyte(statId);
            writer.WriteVarShort((int)boostPoint);
            

}

public override void Deserialize(IDataReader reader)
{

useAdditionnal = reader.ReadBoolean();
            statId = reader.ReadSbyte();
            boostPoint = reader.ReadVarUhShort();
            

}


}


}