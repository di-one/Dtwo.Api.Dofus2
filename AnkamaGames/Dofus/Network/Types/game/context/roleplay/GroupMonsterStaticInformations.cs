


















// Generated on 01/04/2023 15:29:38
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GroupMonsterStaticInformations
{

public const short Id = 2259;
public virtual short TypeId
{
    get { return Id; }
}

public Types.MonsterInGroupLightInformations mainCreatureLightInfos;
        public Types.MonsterInGroupInformations[] underlings;
        

public GroupMonsterStaticInformations()
{
}

public GroupMonsterStaticInformations(Types.MonsterInGroupLightInformations mainCreatureLightInfos, Types.MonsterInGroupInformations[] underlings)
        {
            this.mainCreatureLightInfos = mainCreatureLightInfos;
            this.underlings = underlings;
        }
        

public virtual void Serialize(IDataWriter writer)
{

mainCreatureLightInfos.Serialize(writer);
            writer.WriteShort((short)underlings.Length);
            foreach (var entry in underlings)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

mainCreatureLightInfos = new Types.MonsterInGroupLightInformations();
            mainCreatureLightInfos.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            underlings = new Types.MonsterInGroupInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 underlings[i] = new Types.MonsterInGroupInformations();
                 underlings[i].Deserialize(reader);
            }
            

}


}


}