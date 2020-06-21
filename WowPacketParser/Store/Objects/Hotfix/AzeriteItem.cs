using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteItem, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteItem : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemID;
    }
}
