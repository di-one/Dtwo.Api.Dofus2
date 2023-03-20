


















// Generated on 01/22/2023 17:42:48
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
{

public const uint Id = 3080;
public override uint MessageId
{
    get { return Id; }
}

public double playerId;
        public uint[] skills;
        

public JobMultiCraftAvailableSkillsMessage()
{
}

public JobMultiCraftAvailableSkillsMessage(bool enabled, double playerId, uint[] skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteShort((short)skills.Length);
            foreach (var entry in skills)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            var limit = (ushort)reader.ReadUShort();
            skills = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 skills[i] = reader.ReadVarUhShort();
            }
            

}


}


}