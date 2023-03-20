


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class FriendSpouseOnlineInformations : FriendSpouseInformations
{

public const short Id = 1090;
public override short TypeId
{
    get { return Id; }
}

public bool inFight;
        public bool followSpouse;
        public double mapId;
        public uint subAreaId;
        

public FriendSpouseOnlineInformations()
{
}

public FriendSpouseOnlineInformations(int spouseAccountId, double spouseId, string spouseName, uint spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.GuildInformations guildInfo, sbyte alignmentSide, bool inFight, bool followSpouse, double mapId, uint subAreaId)
         : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
        {
            this.inFight = inFight;
            this.followSpouse = followSpouse;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, inFight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, followSpouse);
            writer.WriteByte(flag1);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            inFight = BooleanByteWrapper.GetFlag(flag1, 0);
            followSpouse = BooleanByteWrapper.GetFlag(flag1, 1);
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
            

}


}


}