


















// Generated on 01/22/2023 17:42:53
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GuildInformationsPaddocksMessage : Dofus2Message
{

public const uint Id = 5220;
public override uint MessageId
{
    get { return Id; }
}

public sbyte nbPaddockMax;
        public Types.PaddockContentInformations[] paddocksInformations;
        

public GuildInformationsPaddocksMessage()
{
}

public GuildInformationsPaddocksMessage(sbyte nbPaddockMax, Types.PaddockContentInformations[] paddocksInformations)
        {
            this.nbPaddockMax = nbPaddockMax;
            this.paddocksInformations = paddocksInformations;
        }
        

public override void Serialize(IDataWriter writer)
{

writer.WriteSbyte(nbPaddockMax);
            writer.WriteShort((short)paddocksInformations.Length);
            foreach (var entry in paddocksInformations)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(IDataReader reader)
{

nbPaddockMax = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            paddocksInformations = new Types.PaddockContentInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 paddocksInformations[i] = new Types.PaddockContentInformations();
                 paddocksInformations[i].Deserialize(reader);
            }
            

}


}


}