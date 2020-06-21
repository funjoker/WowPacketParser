using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ScalingStatDistribution, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ScalingStatDistribution : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? PlayerLevelToItemLevelCurveID;
        
        [DBFieldName("CHANGEME")]
        public int? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public int? MaxLevel;
    }
}
