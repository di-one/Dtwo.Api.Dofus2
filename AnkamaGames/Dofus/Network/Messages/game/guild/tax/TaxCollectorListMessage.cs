


















// Generated on 01/22/2023 17:42:54
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
{

public const uint Id = 5925;
public override uint MessageId
{
    get { return Id; }
}

public sbyte nbcollectorMax;
        public Types.TaxCollectorFightersInformation[] fightersInformations;
        public sbyte infoType;
        

public TaxCollectorListMessage()
{
}

public TaxCollectorListMessage(Types.TaxCollectorInformations[] informations, sbyte nbcollectorMax, Types.TaxCollectorFightersInformation[] fightersInformations, sbyte infoType)
         : base(informations)
        {
            this.nbcollectorMax = nbcollectorMax;
            this.fightersInformations = fightersInformations;
            this.infoType = infoType;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSbyte(nbcollectorMax);
            writer.WriteShort((short)fightersInformations.Length);
            foreach (var entry in fightersInformations)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(infoType);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            nbcollectorMax = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            fightersInformations = new Types.TaxCollectorFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 fightersInformations[i] = new Types.TaxCollectorFightersInformation();
                 fightersInformations[i].Deserialize(reader);
            }
            infoType = reader.ReadSbyte();
            

}


}


}