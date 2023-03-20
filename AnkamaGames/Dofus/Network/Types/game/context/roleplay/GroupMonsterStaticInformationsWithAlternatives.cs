


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GroupMonsterStaticInformationsWithAlternatives : GroupMonsterStaticInformations
{

public const short Id = 6494;
public override short TypeId
{
    get { return Id; }
}

public Types.AlternativeMonstersInGroupLightInformations[] alternatives;
        

public GroupMonsterStaticInformationsWithAlternatives()
{
}

public GroupMonsterStaticInformationsWithAlternatives(Types.AlternativeMonstersInGroupLightInformations[] alternatives)
        {
            this.alternatives = alternatives;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)alternatives.Length);
            foreach (var entry in alternatives)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            alternatives = new Types.AlternativeMonstersInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 alternatives[i] = new Types.AlternativeMonstersInGroupLightInformations();
                 alternatives[i].Deserialize(reader);
            }
            

}


}


}