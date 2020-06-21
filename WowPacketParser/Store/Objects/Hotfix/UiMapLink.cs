using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.UiMapLink)]
    [DBTableName("CHANGEME")]
    public sealed class UiMapLink : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] UiMin;
        
        [HotfixArray(2, true)]
        public float?[] UiMax;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ParentUiMapID;
        
        [DBFieldName("CHANGEME")]
        public int? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public int? ChildUiMapID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? OverrideHighlightFileDataID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? OverrideHighlightAtlasID;
    }
}
