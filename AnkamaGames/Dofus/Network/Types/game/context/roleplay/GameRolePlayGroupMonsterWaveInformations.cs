


















// Generated on 01/22/2023 17:43:04
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
{

public const short Id = 8577;
public override short TypeId
{
    get { return Id; }
}

public sbyte nbWaves;
        public Types.GroupMonsterStaticInformations[] alternatives;
        

public GameRolePlayGroupMonsterWaveInformations()
{
}

public GameRolePlayGroupMonsterWaveInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, Types.GroupMonsterStaticInformations staticInfos, sbyte lootShare, sbyte alignmentSide, sbyte nbWaves, Types.GroupMonsterStaticInformations[] alternatives)
         : base(contextualId, disposition, look, keyRingBonus, hasHardcoreDrop, hasAVARewardToken, staticInfos, lootShare, alignmentSide)
        {
            this.nbWaves = nbWaves;
            this.alternatives = alternatives;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(nbWaves);
            writer.WriteShort((short)alternatives.Length);
            foreach (var entry in alternatives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nbWaves = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            alternatives = new Types.GroupMonsterStaticInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alternatives[i] = ProtocolTypeManager.GetInstance<Types.GroupMonsterStaticInformations>(reader.ReadUShort());
                 alternatives[i].Deserialize(reader);
            }
            

}


}


}