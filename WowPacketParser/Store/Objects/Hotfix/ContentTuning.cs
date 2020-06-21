using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ContentTuning)]
    [DBTableName("CHANGEME")]
    public sealed class ContentTuning : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public int? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, true)]
        public int? ExpectedStatModID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, true)]
        public int? DifficultyESMID;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public int? ExpansionID;
    }
}
