using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactAppearance)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactAppearance : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ArtifactAppearanceSetID;
        
        [DBFieldName("CHANGEME")]
        public byte? DisplayIndex;
        
        [DBFieldName("CHANGEME")]
        public uint? UnlockPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemAppearanceModifierID;
        
        [DBFieldName("CHANGEME")]
        public int? UiSwatchColor;
        
        [DBFieldName("CHANGEME")]
        public float? UiModelSaturation;
        
        [DBFieldName("CHANGEME")]
        public float? UiModelOpacity;
        
        [DBFieldName("CHANGEME")]
        public byte? OverrideShapeshiftFormID;
        
        [DBFieldName("CHANGEME")]
        public uint? OverrideShapeshiftDisplayID;
        
        [DBFieldName("CHANGEME")]
        public uint? UiItemAppearanceID;
        
        [DBFieldName("CHANGEME")]
        public uint? UiAltItemAppearanceID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiCameraID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public uint? UsablePlayerConditionID;
    }
}
