using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.MapDifficulty, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class MapDifficulty : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Message;
        
        [DBFieldName("CHANGEME")]
        public int? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public int? LockID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ResetInterval;
        
        [DBFieldName("CHANGEME")]
        public int? MaxPlayers;
        
        [DBFieldName("CHANGEME")]
        public int? ItemContext;
        
        [DBFieldName("CHANGEME")]
        public int? ItemContextPickerID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? ContentTuningID;
        
        [DBFieldName("CHANGEME")]
        public int? MapID;
    }
}
