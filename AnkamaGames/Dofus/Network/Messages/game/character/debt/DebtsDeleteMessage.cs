


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DebtsDeleteMessage : Dofus2Message
{

public const uint Id = 8822;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public double[] debts;
        

public DebtsDeleteMessage()
{
}

public DebtsDeleteMessage(sbyte reason, double[] debts)
        {
            this.reason = reason;
            this.debts = debts;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(reason);
            writer.WriteShort((short)debts.Length);
            foreach (var entry in debts)
            {
                 writer.WriteDouble(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

reason = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            debts = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 debts[i] = reader.ReadDouble();
            }
            

}


}


}