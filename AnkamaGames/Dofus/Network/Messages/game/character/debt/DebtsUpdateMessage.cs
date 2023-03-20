


















// Generated on 01/22/2023 17:42:41
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class DebtsUpdateMessage : Dofus2Message
{

public const uint Id = 1420;
public override uint MessageId
{
    get { return Id; }
}

public sbyte action;
        public Types.DebtInformation[] debts;
        

public DebtsUpdateMessage()
{
}

public DebtsUpdateMessage(sbyte action, Types.DebtInformation[] debts)
        {
            this.action = action;
            this.debts = debts;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(action);
            writer.WriteShort((short)debts.Length);
            foreach (var entry in debts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

action = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            debts = new Types.DebtInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 debts[i] = ProtocolTypeManager.GetInstance<Types.DebtInformation>(reader.ReadUShort());
                 debts[i].Deserialize(reader);
            }
            

}


}


}