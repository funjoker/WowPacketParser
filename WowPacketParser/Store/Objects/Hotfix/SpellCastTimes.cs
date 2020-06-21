using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellCastTimes, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellCastTimes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Base;
        
        [DBFieldName("CHANGEME")]
        public short? PerLevel;
        
        [DBFieldName("CHANGEME")]
        public int? Minimum;
    }
}
