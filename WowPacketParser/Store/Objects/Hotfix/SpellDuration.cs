using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellDuration, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellDuration : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Duration;
        
        [DBFieldName("CHANGEME")]
        public uint? DurationPerLevel;
        
        [DBFieldName("CHANGEME")]
        public int? MaxDuration;
    }
}
