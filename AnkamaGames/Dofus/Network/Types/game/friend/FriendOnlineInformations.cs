


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FriendOnlineInformations : FriendInformations
{

public const short Id = 1113;
public override short TypeId
{
    get { return Id; }
}

public bool sex;
        public bool havenBagShared;
        public double playerId;
        public string playerName;
        public uint level;
        public sbyte alignmentSide;
        public sbyte breed;
        public Types.GuildInformations guildInfo;
        public uint moodSmileyId;
        public Types.PlayerStatus status;
        

public FriendOnlineInformations()
{
}

public FriendOnlineInformations(int accountId, Types.AccountTagInformation accountTag, sbyte playerState, uint lastConnection, int achievementPoints, int leagueId, int ladderPosition, bool sex, bool havenBagShared, double playerId, string playerName, uint level, sbyte alignmentSide, sbyte breed, Types.GuildInformations guildInfo, uint moodSmileyId, Types.PlayerStatus status)
         : base(accountId, accountTag, playerState, lastConnection, achievementPoints, leagueId, ladderPosition)
        {
            this.sex = sex;
            this.havenBagShared = havenBagShared;
            this.playerId = playerId;
            this.playerName = playerName;
            this.level = level;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.guildInfo = guildInfo;
            this.moodSmileyId = moodSmileyId;
            this.status = status;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, sex);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, havenBagShared);
            writer.WriteByte(flag1);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteVarShort((int)level);
            writer.WriteSbyte(alignmentSide);
            writer.WriteSbyte(breed);
            guildInfo.Serialize(writer);
            writer.WriteVarShort((int)moodSmileyId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            sex = BooleanByteWrapper.GetFlag(flag1, 0);
            havenBagShared = BooleanByteWrapper.GetFlag(flag1, 1);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            level = reader.ReadVarUhShort();
            alignmentSide = reader.ReadSbyte();
            breed = reader.ReadSbyte();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            moodSmileyId = reader.ReadVarUhShort();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            

}


}


}