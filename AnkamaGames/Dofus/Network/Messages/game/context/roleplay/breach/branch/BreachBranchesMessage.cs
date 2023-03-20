


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachBranchesMessage : Dofus2Message
{

public const uint Id = 7075;
public override uint MessageId
{
    get { return Id; }
}

public Types.ExtendedBreachBranch[] branches;
        

public BreachBranchesMessage()
{
}

public BreachBranchesMessage(Types.ExtendedBreachBranch[] branches)
        {
            this.branches = branches;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)branches.Length);
            foreach (var entry in branches)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            branches = new Types.ExtendedBreachBranch[limit];
            for (int i = 0; i < limit; i++)
            {
                 branches[i] = ProtocolTypeManager.GetInstance<Types.ExtendedBreachBranch>(reader.ReadUShort());
                 branches[i].Deserialize(reader);
            }
            

}


}


}