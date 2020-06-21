using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.RewardPackXCurrencyType, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class RewardPackXCurrencyType : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? CurrencyTypeID;
        
        [DBFieldName("CHANGEME")]
        public int? Quantity;
        
        [DBFieldName("CHANGEME")]
        public uint? RewardPackID;
    }
}
