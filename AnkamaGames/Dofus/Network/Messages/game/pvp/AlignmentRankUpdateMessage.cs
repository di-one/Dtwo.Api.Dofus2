


















// Generated on 01/22/2023 17:43:00
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class AlignmentRankUpdateMessage : Dofus2Message
{

public const uint Id = 8954;
public override uint MessageId
{
    get { return Id; }
}

public sbyte alignmentRank;
        public bool verbose;
        

public AlignmentRankUpdateMessage()
{
}

public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
        {
            this.alignmentRank = alignmentRank;
            this.verbose = verbose;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(alignmentRank);
            writer.WriteBoolean(verbose);
            

}

public override void Deserialize(IDataReader reader)
{

alignmentRank = reader.ReadSbyte();
            verbose = reader.ReadBoolean();
            

}


}


}