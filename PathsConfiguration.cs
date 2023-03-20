using System.Runtime.Serialization;

namespace Dtwo.API.Dofus2
{
    [DataContract]
    public class PathsConfiguration
    {
        [DataMember]
        public string DofusBasePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ankama", "Dofus");
        [DataMember]
        public string DofusContentBasePath { get; set; } = "content";
        [DataMember]
        public string DofusContentAudioBasePath { get; set; } = "audio";
        [DataMember]
        public string DofusContentGfxBasePath { get; set; } = "gfx";
        [DataMember]
        public string DofusContentMapsBasePath { get; set; } = "maps";
        [DataMember]
        public string DofusDataBasePath { get; set; } = "data";
        [DataMember]
        public string DofusDataI18NBasePath { get; set; } = "i18n";
        [DataMember]
        public string DofusDataBindsBasePath { get; set; } = "binds";
        [DataMember]
        public string DofusDataCommonBasePath { get; set; } = "common";
        [DataMember]
        public string DtwoDataBasePath { get; set; } = "Data";
    }
}
