using Dtwo.API.Dofus2.Encoding;

namespace Dtwo.API.Dofus2.AnkamaGames.Atouin
{
    internal class EntityGraphicalElementData : GraphicalElementData
    {
        public string EntityLook { get; private set; }
        public bool HorizontalSymmetry { get; private set; }
        public bool PlayAnimation { get; private set; }
        public bool PlayAnimStatic { get; private set; }
        public uint MinDelay { get; private set; }
        public uint MaxDelay { get; private set; }
        public EntityGraphicalElementData(int elementId, int elementType) : base(elementId, elementType)
        {

        }

        public override void FromRaw(BigEndianReader reader, int version)
        {
            int entityLookLength = reader.ReadInt();
            EntityLook = reader.ReadUTFBytes((ushort)entityLookLength);
            HorizontalSymmetry = reader.ReadBoolean();

            if (version >= 7)
            {
                PlayAnimation = reader.ReadBoolean();
            }

            if (version >= 6)
            {
                PlayAnimStatic = reader.ReadBoolean();
            }

            if (version >= 5)
            {
                MinDelay = (uint)reader.ReadInt();
                MaxDelay = (uint)reader.ReadInt();
            }
        }
    }
}
