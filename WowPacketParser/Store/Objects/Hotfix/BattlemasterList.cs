using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BattlemasterList, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BattlemasterList : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string GameType;
        
        [DBFieldName("CHANGEME")]
        public string ShortDescription;
        
        [DBFieldName("CHANGEME")]
        public string LongDescription;
        
        [DBFieldName("CHANGEME")]
        public sbyte? InstanceType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public sbyte? RatedPlayers;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinPlayers;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxPlayers;
        
        [DBFieldName("CHANGEME")]
        public sbyte? GroupsAllowed;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxGroupSize;
        
        [DBFieldName("CHANGEME")]
        public short? HolidayWorldState;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public short? RequiredPlayerConditionID;
        
        [HotfixArray(16)]
        public short?[] MapID;
    }
}
