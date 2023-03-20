


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaInvitationCandidatesAnswerMessage : Dofus2Message
{

public const uint Id = 5561;
public override uint MessageId
{
    get { return Id; }
}

public Types.LeagueFriendInformations[] candidates;
        

public GameRolePlayArenaInvitationCandidatesAnswerMessage()
{
}

public GameRolePlayArenaInvitationCandidatesAnswerMessage(Types.LeagueFriendInformations[] candidates)
        {
            this.candidates = candidates;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)candidates.Length);
            foreach (var entry in candidates)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            candidates = new Types.LeagueFriendInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 candidates[i] = new Types.LeagueFriendInformations();
                 candidates[i].Deserialize(reader);
            }
            

}


}


}