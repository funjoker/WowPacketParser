using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactAppearanceSet)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactAppearanceSet : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? DisplayIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiCameraID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AltHandUICameraID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ForgeAttachmentOverride;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactID;
    }
}
