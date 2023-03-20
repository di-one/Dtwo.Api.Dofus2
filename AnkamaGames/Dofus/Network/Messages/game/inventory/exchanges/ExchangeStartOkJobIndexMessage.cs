


















// Generated on 01/22/2023 17:42:58
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ExchangeStartOkJobIndexMessage : Dofus2Message
{

public const uint Id = 4585;
public override uint MessageId
{
    get { return Id; }
}

public uint[] jobs;
        

public ExchangeStartOkJobIndexMessage()
{
}

public ExchangeStartOkJobIndexMessage(uint[] jobs)
        {
            this.jobs = jobs;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)jobs.Length);
            foreach (var entry in jobs)
            {
                 writer.WriteVarInt((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            jobs = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 jobs[i] = reader.ReadVarUhInt();
            }
            

}


}


}