using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemNameDescription, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemNameDescription : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public int? Color;
    }
}
