using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.UiMap)]
    [DBTableName("CHANGEME")]
    public sealed class UiMap : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ParentUiMapID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? System;
        
        [DBFieldName("CHANGEME")]
        public int? Type;
        
        [DBFieldName("CHANGEME")]
        public uint? LevelRangeMin;
        
        [DBFieldName("CHANGEME")]
        public uint? LevelRangeMax;
        
        [DBFieldName("CHANGEME")]
        public int? BountySetID;
        
        [DBFieldName("CHANGEME")]
        public uint? BountyDisplayLocation;
        
        [DBFieldName("CHANGEME")]
        public int? VisibilityPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? HelpTextPosition;
        
        [DBFieldName("CHANGEME")]
        public int? BkgAtlasID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? AlternateUiMapGroup;
    }
}
