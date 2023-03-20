using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class MapData
    {
        // Fields
        public long BackgroundAlpha;
        public int BackgroundBlue;
        public List<Fixture> BackgroundFixtures = new List<Fixture>();
        public int BackgroundGreen;
        public int BackgroundRed;
        public int BackgroundsCount;
        public int BottomNeighbourId;
        public List<CellData> cells = new List<CellData>();
        public List<NormalGraphicalElementData> gfxList = new List<NormalGraphicalElementData>();
        public int CellsCount { get; private set; }
        public bool Encrypted;
        public int EncryptedVersion;
        public List<Fixture> ForegroundFixtures = new List<Fixture>();
        public int ForegroundsCount;
        public string GroundCRC;
        public int Id;
        public bool IsUsingNewMovementSystem;
        public List<Layer> Layers = new List<Layer>();
        public int LayersCount;
        public int LeftNeighbourId;
        public int MapType;
        public int MapVersion;
        public int PresetId;
        public int RelativeId;
        public int RightNeighbourId;
        public int ShadowBonusOnEntities;
        public int SubAreaId;
        public int TopNeighbourId;
        public bool UseLowPassFilter;
        public bool UseReverb;
        public int ZoomOffsetX;
        public int ZoomOffsetY;
        public double ZoomScale;
        public uint GridAlpha;
        public uint GridRed;
        public uint GridBlue;
        public uint GridGreen;
        public int TacticalModeTemplateId;

        // Methods
        public List<CellData> Cells
        {
            get { return cells; }
        }

        public bool IsLineOfSight(int cellId)
        {
            return (((cellId >= 0) && (cellId < CellsCount)) && cells[cellId].Los);
        }

        public bool IsWalkable(int cellId)
        {
            return (((cellId >= 0) && (cellId < CellsCount)) && cells[cellId].Mov);
        }

        public void Init(BigEndianReader reader)
        {
            reader.ReadByte();
            MapVersion = reader.ReadByte();
            Id = (int)reader.ReadUInt();

            if (MapVersion >= 7)
            {
                Encrypted = reader.ReadBoolean();
                EncryptedVersion = reader.ReadByte();
                int count = reader.ReadInt();
                if (Encrypted)
                {
                    byte[] buffer = CustomHex.ToArray(CustomHex.FromString("649ae451ca33ec53bbcbcc33becf15f4", false));
                    byte[] buffer2 = reader.ReadBytes(count);
                    for (int n = 0; n < buffer2.Length; n++)
                        buffer2[n] = Convert.ToByte((buffer2[n] ^ buffer[(n % buffer.Length)]));
                    reader = new BigEndianReader(buffer2);
                }
            }

            RelativeId = (int)reader.ReadUInt();
            MapType = reader.ReadByte();
            SubAreaId = reader.ReadInt();
            TopNeighbourId = reader.ReadInt();
            BottomNeighbourId = reader.ReadInt();
            LeftNeighbourId = reader.ReadInt();
            RightNeighbourId = reader.ReadInt();
            ShadowBonusOnEntities = (int)reader.ReadUInt();

            if (MapVersion >= 9)
            {
                int readColor = reader.ReadInt();
                BackgroundAlpha = (readColor & 4278190080) >> 32;
                BackgroundRed = (readColor & 16711680) >> 16;
                BackgroundGreen = (readColor & 65280) >> 8;
                BackgroundBlue = readColor & 255;
                uint readColor2 = reader.ReadUInt();
                GridAlpha = (readColor2 & 4278190080) >> 32;
                GridRed = (readColor2 & 16711680) >> 16;
                GridGreen = (readColor2 & 65280) >> 8;
                GridBlue = readColor2 & 255;
            }
            else if (MapVersion >= 3)
            {
                BackgroundRed = reader.ReadByte();
                BackgroundGreen = reader.ReadByte();
                BackgroundBlue = reader.ReadByte();
            }
            if (MapVersion >= 4)
            {
                ZoomScale = Convert.ToDouble(reader.ReadUShort()) / 100;
                ZoomOffsetX = reader.ReadShort();
                ZoomOffsetY = reader.ReadShort();
            }

            //UseLowPassFilter = reader.ReadBoolean();
            //UseReverb = reader.ReadBoolean();
            //if (UseReverb)
            //    PresetId = reader.ReadInt();
            if (MapVersion > 10)
            {
                TacticalModeTemplateId = reader.ReadInt();
            }

            BackgroundsCount = reader.ReadByte();
            for (int i = 0; i < BackgroundsCount; i++)
            {
                Fixture item = new Fixture();
                item.Init(reader);
                BackgroundFixtures.Add(item);
            }
            ForegroundsCount = reader.ReadByte();
            for (int i = 0; i < ForegroundsCount; i++)
            {
                Fixture fixture2 = new Fixture();
                fixture2.Init(reader);
                ForegroundFixtures.Add(fixture2);
            }
            CellsCount = 560;
            reader.ReadInt();
            GroundCRC = reader.ReadInt().ToString();
            LayersCount = reader.ReadByte();
            for (int i = 0; i < LayersCount; i++)
            {
                Layer layer = new Layer();
                layer.Init(reader, MapVersion);
                Layers.Add(layer);
            }
            uint oldMvtSys = 0;
            for (int i = 0; i < CellsCount; i++)
            {
                CellData data = new CellData();
                data.Init(reader, MapVersion, i);
                if (oldMvtSys == 0)
                    oldMvtSys = data.MoveZone;
                if (data.MoveZone != oldMvtSys)
                    IsUsingNewMovementSystem = true;
                cells.Add(data);
            }
        }

        public void ComputeGfxList(bool skipBackground = false)
        {
            int l = 0;
            int c = 0;
            int e = 0;
            List<Cell> lsCell = null;
            int numCell = 0;
            List<BasicElement> lsElement = null;
            int numElement = 0;
            Layer layer = null;
            Cell cell = null;
            BasicElement element = null;
            int elementId = 0;
            GraphicalElementData elementData = null;
            NormalGraphicalElementData graphicalElementData = null;
            NormalGraphicalElementData gfx = null;
            //Elements ele = Elements.GetInstance();
            Dictionary<int, NormalGraphicalElementData> gfxList = new Dictionary<int, NormalGraphicalElementData>();
            //this._gfxCount = new Dictionary<int, int>();
            int numLayer = this.Layers.Count;
            for (l = 0; l < numLayer; l++)
            {
                layer = this.Layers[l];
                if (!(skipBackground && l == 0))
                {
                    lsCell = layer.Cells;
                    numCell = lsCell.Count;
                    for (c = 0; c < numCell; c++)
                    {
                        cell = lsCell[c];
                        lsElement = cell.Elements;
                        numElement = lsElement.Count;
                        for (e = 0; e < numElement; e++)
                        {
                            element = lsElement[e];

                            if (element.GetType() == typeof(GraphicalElement))
                            {
                                elementId = (element as GraphicalElement).ElementId;
                                elementData = Elements.GetInstance().GetElementData(elementId);
                                if (elementData == null)
                                {
                                    LogManager.LogWarning("Unknown graphical element ID " + elementId);
                                }
                                else if (elementData is NormalGraphicalElementData)
                                {
                                    graphicalElementData = elementData as NormalGraphicalElementData;
                                    gfxList[graphicalElementData.GfxId] = graphicalElementData;
                                    //    if (this._gfxCount.ContainsKey(graphicalElementData.gfxId))
                                    //    {
                                    //        this._gfxCount[graphicalElementData.gfxId]++;
                                    //    }
                                    //    else
                                    //    {
                                    //        this._gfxCount[graphicalElementData.gfxId] = 1;
                                    //    }
                                    //}
                                }
                            }
                        }
                    }
                }
            }

            this.gfxList = new List<NormalGraphicalElementData>();
            foreach (KeyValuePair<int, NormalGraphicalElementData> pair in gfxList)
            {
                if (pair.Value == null)
                {
                    LogManager.LogError("mapdata error");
                    continue;
                }

                this.gfxList.Add(pair.Value);
            }
            this.gfxList.TrimExcess();
        }
    }
}
