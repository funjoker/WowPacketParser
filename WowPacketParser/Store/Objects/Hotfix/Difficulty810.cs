using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.Difficulty, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Difficulty : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? InstanceType;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? OldEnumValue;
        
        [DBFieldName("CHANGEME")]
        public byte? FallbackDifficultyID;
        
        [DBFieldName("CHANGEME")]
        public byte? MinPlayers;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPlayers;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemContext;
        
        [DBFieldName("CHANGEME")]
        public byte? ToggleDifficultyID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GroupSizeHealthCurveID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GroupSizeDmgCurveID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GroupSizeSpellPointsCurveID;
    }
}
