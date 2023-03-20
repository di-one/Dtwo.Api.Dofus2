


















// Generated on 01/22/2023 17:43:07
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class StatedElement
{

public const short Id = 3190;
public virtual short TypeId
{
    get { return Id; }
}

public int elementId;
        public uint elementCellId;
        public uint elementState;
        public bool onCurrentMap;
        

public StatedElement()
{
}

public StatedElement(int elementId, uint elementCellId, uint elementState, bool onCurrentMap)
        {
            this.elementId = elementId;
            this.elementCellId = elementCellId;
            this.elementState = elementState;
            this.onCurrentMap = onCurrentMap;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(elementId);
            writer.WriteVarShort((int)elementCellId);
            writer.WriteVarInt((int)elementState);
            writer.WriteBoolean(onCurrentMap);
            

}

public virtual void Deserialize(IDataReader reader)
{

elementId = reader.ReadInt();
            elementCellId = reader.ReadVarUhShort();
            elementState = reader.ReadVarUhInt();
            onCurrentMap = reader.ReadBoolean();
            

}


}


}