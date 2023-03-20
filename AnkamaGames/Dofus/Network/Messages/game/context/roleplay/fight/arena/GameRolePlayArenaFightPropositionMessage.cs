


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaFightPropositionMessage : Dofus2Message
{

public const uint Id = 4162;
public override uint MessageId
{
    get { return Id; }
}

public uint fightId;
        public double[] alliesId;
        public uint duration;
        

public GameRolePlayArenaFightPropositionMessage()
{
}

public GameRolePlayArenaFightPropositionMessage(uint fightId, double[] alliesId, uint duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)fightId);
            writer.WriteShort((short)alliesId.Length);
            foreach (var entry in alliesId)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteVarShort((int)duration);
            

}

public override void Deserialize(IDataReader reader)
{

fightId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            alliesId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliesId[i] = reader.ReadDouble();
            }
            duration = reader.ReadVarUhShort();
            

}


}


}