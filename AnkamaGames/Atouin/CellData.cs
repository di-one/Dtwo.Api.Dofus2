using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class CellData
    {
        internal void Init(IDataReader Reader, int MapVersion, int id)
        {
            Id = id;

            Floor = (Reader.ReadSByte() * 10);
            if ((Floor != -1280))
            {
                bool topArrow, bottomArrow, rightArrow, leftArrow;

                if (MapVersion >= 9)
                {
                    int temp = Reader.ReadShort();
                    Mov = (temp & 1) == 0;
                    NonWalkableDuringFight = (temp & 2) != 0;
                    NonWalkableDuringRP = (temp & 4) != 0;
                    Los = (temp & 8) == 0;
                    Blue = (temp & 16) != 0;
                    Red = (temp & 32) != 0;
                    Visible = (temp & 64) != 0;
                    FarmCell = (temp & 128) != 0;
                    if (MapVersion >= 10)
                    {
                        HavenbagCell = (temp & 256) != 0;
                        topArrow = (temp & 512) != 0;
                        bottomArrow = (temp & 1024) != 0;
                        rightArrow = (temp & 2048) != 0;
                        leftArrow = (temp & 4096) != 0;
                    }
                    else
                    {
                        topArrow = (temp & 256) != 0;
                        bottomArrow = (temp & 512) != 0;
                        rightArrow = (temp & 1024) != 0;
                        leftArrow = (temp & 2048) != 0;
                    }
                }
                else
                {
                    Losmov = Reader.ReadByte();
                    Los = (Losmov & 2) >> 1 == 1;
                    Mov = (Losmov & 1) == 1;
                    Visible = (Losmov & 64) >> 6 == 1;
                    FarmCell = (Losmov & 32) >> 5 == 1;
                    Blue = (Losmov & 16) >> 4 == 1;
                    Red = (Losmov & 8) >> 3 == 1;
                    NonWalkableDuringRP = (Losmov & 128) >> 7 == 1;
                    NonWalkableDuringFight = (Losmov & 4) >> 2 == 1;
                }

                Speed = Reader.ReadSByte();
                MapChangeData = Reader.ReadSByte();

                if (MapVersion > 5)
                    MoveZone = Reader.ReadByte();

                if (MapVersion > 10 && (HasLinkedZoneRP() || HasLinkedZoneFight()))
                {
                    LinkedZone = Reader.ReadByte();
                }

                if (MapVersion > 7 && MapVersion < 9)
                    Arrow = 15 & Reader.ReadSByte();

            }
        }

        public bool HasLinkedZoneRP()
        {
            return Mov && FarmCell == false;
        }

        public int LinkedZoneRP()
        {
            return (int)((LinkedZone & 240) >> 4);
        }

        public bool HasLinkedZoneFight()
        {
            return (Mov && NonWalkableDuringFight == false && FarmCell == false && HavenbagCell == false);
        }

        public int Speed;
        public int MapChangeData;
        public uint MoveZone;
        public int Losmov = 3;
        public int Floor;
        public int Arrow = 0;
        public uint LinkedZone;
        public Boolean Mov;
        public Boolean Los;
        public Boolean NonWalkableDuringFight;
        public Boolean Red;
        public Boolean Blue;
        public Boolean FarmCell;
        public Boolean HavenbagCell;
        public Boolean Visible;
        public Boolean NonWalkableDuringRP;
        public int Id;

    }
}
