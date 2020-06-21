using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Mount)]
    [DBTableName("CHANGEME")]
    public sealed class Mount : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string SourceText;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? MountTypeID;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SourceTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public int? SourceSpellID;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public float? MountFlyRideHeight;
        
        [DBFieldName("CHANGEME")]
        public int? UiModelSceneID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? MountSpecialRiderAnimKitID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? MountSpecialSpellVisualKitID;
    }
}
