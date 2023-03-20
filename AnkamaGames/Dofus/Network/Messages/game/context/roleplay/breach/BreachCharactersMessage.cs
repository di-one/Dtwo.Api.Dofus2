


















// Generated on 01/22/2023 17:42:45
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class BreachCharactersMessage : Dofus2Message
{

public const uint Id = 611;
public override uint MessageId
{
    get { return Id; }
}

public double[] characters;
        

public BreachCharactersMessage()
{
}

public BreachCharactersMessage(double[] characters)
        {
            this.characters = characters;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)characters.Length);
            foreach (var entry in characters)
            {
                 writer.WriteVarLong(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            characters = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 characters[i] = reader.ReadVarUhLong();
            }
            

}


}


}