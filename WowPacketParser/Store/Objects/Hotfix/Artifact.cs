using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Artifact)]
    [DBTableName("CHANGEME")]
    public sealed class Artifact : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiTextureKitID;
        
        [DBFieldName("CHANGEME")]
        public int? UiNameColor;
        
        [DBFieldName("CHANGEME")]
        public int? UiBarOverlayColor;
        
        [DBFieldName("CHANGEME")]
        public int? UiBarBackgroundColor;
        
        [DBFieldName("CHANGEME")]
        public ushort? ChrSpecializationID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactCategoryID;
        
        [DBFieldName("CHANGEME")]
        public uint? UiModelSceneID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellVisualKitID;
    }
}
