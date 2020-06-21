using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ScenarioStep, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ScenarioStep : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public string Title;
        
        [DBFieldName("CHANGEME")]
        public ushort? ScenarioID;
        
        [DBFieldName("CHANGEME")]
        public uint? Criteriatreeid;
        
        [DBFieldName("CHANGEME")]
        public ushort? RewardQuestID;
        
        [DBFieldName("CHANGEME")]
        public int? RelatedStep;
        
        [DBFieldName("CHANGEME")]
        public ushort? Supersedes;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? VisibilityPlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? WidgetSetID;
    }
}
