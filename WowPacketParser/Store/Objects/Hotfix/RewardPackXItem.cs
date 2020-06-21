using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.RewardPackXItem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class RewardPackXItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemQuantity;
        
        [DBFieldName("CHANGEME")]
        public int? RewardPackID;
    }
}
