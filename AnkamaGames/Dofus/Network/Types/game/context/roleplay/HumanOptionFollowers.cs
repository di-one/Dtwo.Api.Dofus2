


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class HumanOptionFollowers : HumanOption
{

public const short Id = 5290;
public override short TypeId
{
    get { return Id; }
}

public Types.IndexedEntityLook[] followingCharactersLook;
        

public HumanOptionFollowers()
{
}

public HumanOptionFollowers(Types.IndexedEntityLook[] followingCharactersLook)
        {
            this.followingCharactersLook = followingCharactersLook;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)followingCharactersLook.Length);
            foreach (var entry in followingCharactersLook)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            followingCharactersLook = new Types.IndexedEntityLook[limit];
            for (int i = 0; i < limit; i++)
            {
                 followingCharactersLook[i] = new Types.IndexedEntityLook();
                 followingCharactersLook[i].Deserialize(reader);
            }
            

}


}


}