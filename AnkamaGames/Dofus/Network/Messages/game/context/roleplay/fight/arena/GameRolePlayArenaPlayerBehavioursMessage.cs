


















// Generated on 01/22/2023 17:42:46
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameRolePlayArenaPlayerBehavioursMessage : Dofus2Message
{

public const uint Id = 3636;
public override uint MessageId
{
    get { return Id; }
}

public string[] flags;
        public string[] sanctions;
        public int banDuration;
        

public GameRolePlayArenaPlayerBehavioursMessage()
{
}

public GameRolePlayArenaPlayerBehavioursMessage(string[] flags, string[] sanctions, int banDuration)
        {
            this.flags = flags;
            this.sanctions = sanctions;
            this.banDuration = banDuration;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)flags.Length);
            foreach (var entry in flags)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)sanctions.Length);
            foreach (var entry in sanctions)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteInt(banDuration);
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            flags = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 flags[i] = reader.ReadUTF();
            }
            limit = (ushort)reader.ReadUShort();
            sanctions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 sanctions[i] = reader.ReadUTF();
            }
            banDuration = reader.ReadInt();
            

}


}


}