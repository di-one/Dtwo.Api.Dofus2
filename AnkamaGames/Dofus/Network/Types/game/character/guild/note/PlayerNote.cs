


















// Generated on 01/22/2023 17:43:03
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class PlayerNote
{

public const short Id = 7031;
public virtual short TypeId
{
    get { return Id; }
}

public string content;
        public double lastEditDate;
        

public PlayerNote()
{
}

public PlayerNote(string content, double lastEditDate)
        {
            this.content = content;
            this.lastEditDate = lastEditDate;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteUTF(content);
            writer.WriteDouble(lastEditDate);
            

}

public virtual void Deserialize(IDataReader reader)
{

content = reader.ReadUTF();
            lastEditDate = reader.ReadDouble();
            

}


}


}