


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HumanOptionEmote : HumanOption
{

public const short Id = 7493;
public override short TypeId
{
    get { return Id; }
}

public ushort emoteId;
        public double emoteStartTime;
        

public HumanOptionEmote()
{
}

public HumanOptionEmote(ushort emoteId, double emoteStartTime)
        {
            this.emoteId = emoteId;
            this.emoteStartTime = emoteStartTime;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort(emoteId);
            writer.WriteDouble(emoteStartTime);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            emoteId = reader.ReadUShort();
            emoteStartTime = reader.ReadDouble();
            

}


}


}