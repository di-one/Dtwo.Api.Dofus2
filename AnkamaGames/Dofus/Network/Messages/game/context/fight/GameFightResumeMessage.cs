


















// Generated on 01/22/2023 17:42:43
using System;
using System.Collections.Generic;
using System.Linq;
using Dtwo.API.Dofus2.AnkamaGames.Network.Types;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.Network.Messages;

namespace Dtwo.API.Dofus2.AnkamaGames.Network.Messages
{

public class GameFightResumeMessage : GameFightSpectateMessage
{

public const uint Id = 5983;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightSpellCooldown[] spellCooldowns;
        public sbyte summonCount;
        public sbyte bombCount;
        

public GameFightResumeMessage()
{
}

public GameFightResumeMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, uint gameTurn, int fightStart, Types.Idol[] idols, Types.GameFightEffectTriggerCount[] fxTriggerCounts, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount)
         : base(effects, marks, gameTurn, fightStart, idols, fxTriggerCounts)
        {
            this.spellCooldowns = spellCooldowns;
            this.summonCount = summonCount;
            this.bombCount = bombCount;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteShort((short)spellCooldowns.Length);
            foreach (var entry in spellCooldowns)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSbyte(summonCount);
            writer.WriteSbyte(bombCount);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            spellCooldowns = new Types.GameFightSpellCooldown[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellCooldowns[i] = new Types.GameFightSpellCooldown();
                 spellCooldowns[i].Deserialize(reader);
            }
            summonCount = reader.ReadSbyte();
            bombCount = reader.ReadSbyte();
            

}


}


}