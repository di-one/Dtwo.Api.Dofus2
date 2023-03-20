


















// Generated on 01/22/2023 17:43:06
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Types
{

public class GuildEmblem
{

public const short Id = 6191;
public virtual short TypeId
{
    get { return Id; }
}

public uint symbolShape;
        public int symbolColor;
        public sbyte backgroundShape;
        public int backgroundColor;
        

public GuildEmblem()
{
}

public GuildEmblem(uint symbolShape, int symbolColor, sbyte backgroundShape, int backgroundColor)
        {
            this.symbolShape = symbolShape;
            this.symbolColor = symbolColor;
            this.backgroundShape = backgroundShape;
            this.backgroundColor = backgroundColor;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)symbolShape);
            writer.WriteInt(symbolColor);
            writer.WriteSbyte(backgroundShape);
            writer.WriteInt(backgroundColor);
            

}

public virtual void Deserialize(IDataReader reader)
{

symbolShape = reader.ReadVarUhShort();
            symbolColor = reader.ReadInt();
            backgroundShape = reader.ReadSbyte();
            backgroundColor = reader.ReadInt();
            

}


}


}