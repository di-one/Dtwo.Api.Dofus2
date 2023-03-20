

















// Generated on 01/23/2023 12:54:02
using System;
using System.Collections.Generic;
using Dtwo.API.Dofus2.Encoding;
using Dtwo.API.Dofus2.AnkamaGames.Jerakine.Data;
using Dtwo.API.DofusBase.Data;

namespace Dtwo.API.Dofus2.AnkamaGames.Dofus.DataCenter
{

public class Playlist : DofusData
{

public const int AMBIENT_TYPE_ROLEPLAY = 1;
        public const int AMBIENT_TYPE_AMBIENT = 2;
        public const int AMBIENT_TYPE_FIGHT = 3;
        public const int AMBIENT_TYPE_BOSS = 4;
        public const String MODULE = "Playlists";
        public int id;
        public int type;
        public List<PlaylistSound> sounds;
        public Boolean startRandom;
        public Boolean startRandomOnce;
        public int crossfadeDuration;
        public Boolean random;
        

}

}