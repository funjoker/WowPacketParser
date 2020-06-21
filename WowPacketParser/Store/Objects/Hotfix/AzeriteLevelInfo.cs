using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteLevelInfo, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteLevelInfo : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ulong? BaseExperienceToNextLevel;
        
        [DBFieldName("CHANGEME")]
        public ulong? MinimumExperienceToNextLevel;
        
        [DBFieldName("CHANGEME")]
        public int? ItemLevel;
    }
}
