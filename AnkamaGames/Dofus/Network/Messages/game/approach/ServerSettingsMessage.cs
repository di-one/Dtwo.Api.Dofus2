


















// Generated on 01/22/2023 17:42:40
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class ServerSettingsMessage : Dofus2Message
{

public const uint Id = 5820;
public override uint MessageId
{
    get { return Id; }
}

public bool isMonoAccount;
        public bool hasFreeAutopilot;
        public string lang;
        public sbyte community;
        public sbyte gameType;
        public uint arenaLeaveBanTime;
        public int itemMaxLevel;
        

public ServerSettingsMessage()
{
}

public ServerSettingsMessage(bool isMonoAccount, bool hasFreeAutopilot, string lang, sbyte community, sbyte gameType, uint arenaLeaveBanTime, int itemMaxLevel)
        {
            this.isMonoAccount = isMonoAccount;
            this.hasFreeAutopilot = hasFreeAutopilot;
            this.lang = lang;
            this.community = community;
            this.gameType = gameType;
            this.arenaLeaveBanTime = arenaLeaveBanTime;
            this.itemMaxLevel = itemMaxLevel;
        }
        

public override void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isMonoAccount);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, hasFreeAutopilot);
            writer.WriteByte(flag1);
            writer.WriteUTF(lang);
            writer.WriteSbyte(community);
            writer.WriteSbyte(gameType);
            writer.WriteVarShort((int)arenaLeaveBanTime);
            writer.WriteInt(itemMaxLevel);
            

}

public override void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isMonoAccount = BooleanByteWrapper.GetFlag(flag1, 0);
            hasFreeAutopilot = BooleanByteWrapper.GetFlag(flag1, 1);
            lang = reader.ReadUTF();
            community = reader.ReadSbyte();
            gameType = reader.ReadSbyte();
            arenaLeaveBanTime = reader.ReadVarUhShort();
            itemMaxLevel = reader.ReadInt();
            

}


}


}