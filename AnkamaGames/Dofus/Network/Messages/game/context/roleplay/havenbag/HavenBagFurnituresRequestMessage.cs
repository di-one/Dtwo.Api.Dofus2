


















// Generated on 01/22/2023 17:42:47
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class HavenBagFurnituresRequestMessage : Dofus2Message
{

public const uint Id = 9671;
public override uint MessageId
{
    get { return Id; }
}

public uint[] cellIds;
        public int[] funitureIds;
        public sbyte[] orientations;
        

public HavenBagFurnituresRequestMessage()
{
}

public HavenBagFurnituresRequestMessage(uint[] cellIds, int[] funitureIds, sbyte[] orientations)
        {
            this.cellIds = cellIds;
            this.funitureIds = funitureIds;
            this.orientations = orientations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteShort((short)cellIds.Length);
            foreach (var entry in cellIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)funitureIds.Length);
            foreach (var entry in funitureIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarInt((int)(ushort)orientations.Length);
            foreach (var entry in orientations)
            {
                 writer.WriteSbyte(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

var limit = (ushort)reader.ReadUShort();
            cellIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cellIds[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            funitureIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 funitureIds[i] = reader.ReadInt();
            }
            limit = (ushort)reader.ReadVarInt();
            orientations = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 orientations[i] = reader.ReadSbyte();
            }
            

}


}


}