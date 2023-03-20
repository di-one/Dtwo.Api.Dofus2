using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    public abstract class BasicElement
    {
        public enum Type : int
        {
            Graphical = 2,
            Sound = 33
        }

        public abstract int ElementType { get; protected set; }

        protected BasicElement()
        {

        }

        public static BasicElement GetElementFromType(int typeId)
        {
            switch (typeId)
            {
                case 2:
                    return new GraphicalElement();
                case 33:
                    return new SoundElement();
            }
            //Console.WriteLine($"Errror : BasicElement with {typeId} is not correct");
            return null;
        }

        internal abstract void Init(IDataReader reader, int mapVersion);
    }
}
