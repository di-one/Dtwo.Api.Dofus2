


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
{

public const short Id = 2890;
public override short TypeId
{
    get { return Id; }
}

public Types.HumanInformations humanoidInfo;
        public int accountId;
        

public GameRolePlayHumanoidInformations()
{
}

public GameRolePlayHumanoidInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId)
         : base(contextualId, disposition, look, name)
        {
            this.humanoidInfo = humanoidInfo;
            this.accountId = accountId;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(humanoidInfo.TypeId);
            humanoidInfo.Serialize(writer);
            writer.WriteInt(accountId);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            humanoidInfo = ProtocolTypeManager.GetInstance<Types.HumanInformations>(reader.ReadUShort());
            humanoidInfo.Deserialize(reader);
            accountId = reader.ReadInt();
            

}


}


}