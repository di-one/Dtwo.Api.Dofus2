


















// Generated on 01/22/2023 17:42:36
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class IdentificationAccountForceMessage : IdentificationMessage
{

public const uint Id = 5556;
public override uint MessageId
{
    get { return Id; }
}

public string forcerAccountLogin;
        

public IdentificationAccountForceMessage()
{
}

public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.Version version, string lang, sbyte[] credentials, short serverId, double sessionOptionalSalt, uint[] failedAttempts, string forcerAccountLogin)
         : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt, failedAttempts)
        {
            this.forcerAccountLogin = forcerAccountLogin;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(forcerAccountLogin);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            forcerAccountLogin = reader.ReadUTF();
            

}


}


}