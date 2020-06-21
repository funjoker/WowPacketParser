using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemLimitCategory, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemLimitCategory : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? Quantity;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
