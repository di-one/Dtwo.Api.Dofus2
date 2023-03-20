


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class AcquaintanceOnlineInformation : AcquaintanceInformation
{

public const short Id = 9922;
public override short TypeId
{
    get { return Id; }
}

public double playerId;
        public string playerName;
        public uint moodSmileyId;
        public Types.PlayerStatus status;
        

public AcquaintanceOnlineInformation()
{
}

public AcquaintanceOnlineInformation(int accountId, Types.AccountTagInformation accountTag, sbyte playerState, double playerId, string playerName, uint moodSmileyId, Types.PlayerStatus status)
         : base(accountId, accountTag, playerState)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.moodSmileyId = moodSmileyId;
            this.status = status;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteVarShort((int)moodSmileyId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            moodSmileyId = reader.ReadVarUhShort();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            

}


}


}