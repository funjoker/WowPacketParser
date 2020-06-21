using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemRandomProperties, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemRandomProperties : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(5)]
        public ushort?[] Enchantment;
    }
}
