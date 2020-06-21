using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BankBagSlotPrices, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BankBagSlotPrices : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? Cost;
    }
}
