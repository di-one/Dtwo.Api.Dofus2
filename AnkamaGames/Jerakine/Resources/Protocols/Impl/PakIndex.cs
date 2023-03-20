namespace Dtwo.API.Dofus2.AnkamaGames.Jerakine.Resources.Protocols
{
    public class PakIndex
    {
        public FileStream Stream { get; set; }
        public int FileLenght { get; set; }
        public long FileOffset { get; set; }

        public PakIndex(FileStream stream, int fileLength, long fileOffset)
        {
            Stream = stream;
            FileLenght = fileLength;
            FileOffset = fileOffset;
        }

        public PakIndex()
        {

        }
    }
}
