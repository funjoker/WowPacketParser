using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemCurrencyCost, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemCurrencyCost : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
    }
}
