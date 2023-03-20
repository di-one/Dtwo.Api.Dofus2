using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class Elements
    {
        private static Elements _self;

        public int fileVersion;
        public uint elementsCount;
        private bool _parsed;
        private bool _failed;
        public Dictionary<int, GraphicalElementData> _elementsMap;
        private Dictionary<uint, bool> _jpgMap;
        public Dictionary<int, int> _elementsIndex;
        private BigEndianReader _rawData;

        public Elements()
        {
            if (_self != null)
            {
                throw new Exception("Singleton error");
            }
        }

        public static Elements GetInstance()
        {
            if (_self == null)
            {
                _self = new Elements();
            }
            return _self;
        }

        public bool parsed => this._parsed;

        public bool failed => this._failed;

        public GraphicalElementData GetElementData(int elementId)
        {
            if (this._elementsMap.ContainsKey(elementId))
            {
                return this._elementsMap[elementId];
            }
            return this.ReadElement(elementId);
        }

        public bool IsJpg(uint gfxId)
        {
            return this._jpgMap.ContainsKey(gfxId) && this._jpgMap[gfxId];
        }

        public void FromRaw(BigEndianReader raw)
        {
            int header = 0;
            uint skypLen = 0;
            int i = 0;
            int edId = 0;
            int gfxCount = 0;
            uint gfxId = 0;

            Console.WriteLine("FromRaw 1");

            try
            {
                header = raw.ReadByte();
                if (header != 69)
                {
                    throw new Exception("Unknown file format");
                }

                Console.WriteLine("FromRaw 2");

                this._rawData = raw;
                this.fileVersion = raw.ReadByte();

                this.elementsCount = (uint)raw.ReadUInt();
                this._elementsMap = new Dictionary<int, GraphicalElementData>();
                this._elementsIndex = new Dictionary<int, int>();
                skypLen = 0;

                Console.WriteLine("FromRaw 3 " + elementsCount + " file version " + fileVersion);

                for (i = 0; i < this.elementsCount; i++)
                {
                    if (this.fileVersion >= 9)
                    {
                        skypLen = (uint)raw.ReadUShort();
                    }
                    edId = raw.ReadInt();
                    if (this.fileVersion <= 8)
                    {
                        this._elementsIndex[edId] = (int)raw.Position;
                        this.ReadElement(edId);
                    }
                    else
                    {

                        Console.WriteLine("Add elemIndex");
                        this._elementsIndex[edId] = (int)raw.Position;
                        raw.BaseStream.Position += skypLen - 4;
                    }
                }
                if (this.fileVersion >= 8)
                {
                    gfxCount = raw.ReadInt();
                    this._jpgMap = new Dictionary<uint, bool>();
                    for (i = 0; i < gfxCount; i++)
                    {
                        gfxId = (uint)raw.ReadInt();
                        this._jpgMap[gfxId] = true;
                    }
                }
                this._parsed = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("error : " + e.Message);
                _failed = true;
                throw e;
            }
        }

        private GraphicalElementData ReadElement(int edId)
        {
            Console.WriteLine("ReadElement " + edId);

            this._rawData.BaseStream.Position = this._elementsIndex[edId];
            int edType = this._rawData.ReadByte();
            GraphicalElementData ed;
            switch (edType)
            {
                case 0:
                    ed = new NormalGraphicalElementData(edId, edType);
                    break;
                case 1:
                    ed = new BoundingGraphicalElementData(edId, edType);
                    break;
                case 2:
                    ed = new AnimatedGraphicalElementData(edId, edType);
                    break;
                case 3:
                    ed = new EntityGraphicalElementData(edId, edType);
                    break;
                case 4:
                    ed = new ParticlesGraphicalElementData(edId, edType);
                    break;
                case 5:
                    ed = new BlendedGraphicalElementData(edId, edType);
                    break;
                default:
                    throw new Exception("Unknown element type " + edType);
            }

            ed.FromRaw(this._rawData, this.fileVersion);
            this._elementsMap[edId] = ed;
            return ed;
        }
    }
}

