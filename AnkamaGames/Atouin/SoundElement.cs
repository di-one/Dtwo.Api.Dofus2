using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public class SoundElement : BasicElement
    {
        // Fields
        public int BaseVolume;
        public int FullVolumeDistance;
        public int MaxDelayBetweenLoops;
        public int MinDelayBetweenLoops;
        public int NullVolumeDistance;
        public int SoundId;

        public override int ElementType { get; protected set; } = (int)Type.Sound; 

        internal override void Init(IDataReader Reader, int MapVersion)
        {
            this.SoundId = Reader.ReadInt();
            this.BaseVolume = Reader.ReadShort();
            this.FullVolumeDistance = Reader.ReadInt();
            this.NullVolumeDistance = Reader.ReadInt();
            this.MinDelayBetweenLoops = Reader.ReadShort();
            this.MaxDelayBetweenLoops = Reader.ReadShort();
        }
    }
}
