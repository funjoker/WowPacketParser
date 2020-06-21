using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_5_31921.Hotfix
{
    [HotfixStructure(DB2Hash.SpellMisc, ClientVersionBuild.V8_2_5_31921, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellMisc : IDataModel
    {
        [HotfixArray(14)]
        public int?[] Attributes;
        
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CastingTimeIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? DurationIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? RangeIndex;
        
        [DBFieldName("CHANGEME")]
        public byte? SchoolMask;
        
        [DBFieldName("CHANGEME")]
        public float? Speed;
        
        [DBFieldName("CHANGEME")]
        public float? LaunchDelay;
        
        [DBFieldName("CHANGEME")]
        public float? MinDuration;
        
        [DBFieldName("CHANGEME")]
        public int? SpellIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? ActiveIconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? ContentTuningID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
