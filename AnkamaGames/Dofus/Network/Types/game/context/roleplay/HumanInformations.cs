


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HumanInformations
{

public const short Id = 4254;
public virtual short TypeId
{
    get { return Id; }
}

public Types.ActorRestrictionsInformations restrictions;
        public bool sex;
        public Types.HumanOption[] options;
        

public HumanInformations()
{
}

public HumanInformations(Types.ActorRestrictionsInformations restrictions, bool sex, Types.HumanOption[] options)
        {
            this.restrictions = restrictions;
            this.sex = sex;
            this.options = options;
        }
        

public virtual void Serialize(IDataWriter writer)
{

restrictions.Serialize(writer);
            writer.WriteBoolean(sex);
            writer.WriteShort((short)options.Length);
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
            sex = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 options[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadUShort());
                 options[i].Deserialize(reader);
            }
            

}


}


}