


















// Generated on 01/22/2023 17:42:37
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
{

public const uint Id = 3580;
public override uint MessageId
{
    get { return Id; }
}

public int boostUID;
        

public GameActionFightDispellEffectMessage()
{
}

public GameActionFightDispellEffectMessage(uint actionId, double sourceId, double targetId, bool verboseCast, int boostUID)
         : base(actionId, sourceId, targetId, verboseCast)
        {
            this.boostUID = boostUID;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(boostUID);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            boostUID = reader.ReadInt();
            

}


}


}