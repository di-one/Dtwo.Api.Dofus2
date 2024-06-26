


















// Generated on 01/22/2023 17:43:05
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GameRolePlayNpcQuestFlag
{

public const short Id = 2213;
public virtual short TypeId
{
    get { return Id; }
}

public uint[] questsToValidId;
        public uint[] questsToStartId;
        

public GameRolePlayNpcQuestFlag()
{
}

public GameRolePlayNpcQuestFlag(uint[] questsToValidId, uint[] questsToStartId)
        {
            this.questsToValidId = questsToValidId;
            this.questsToStartId = questsToStartId;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteShort((short)questsToValidId.Length);
            foreach (var entry in questsToValidId)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)questsToStartId.Length);
            foreach (var entry in questsToStartId)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            questsToValidId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToValidId[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            questsToStartId = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 questsToStartId[i] = reader.ReadVarUhShort();
            }
            

}


}


}