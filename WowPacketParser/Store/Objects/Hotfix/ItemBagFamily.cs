using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemBagFamily, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemBagFamily : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
    }
}
