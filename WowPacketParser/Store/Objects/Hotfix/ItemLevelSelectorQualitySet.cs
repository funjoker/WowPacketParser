using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemLevelSelectorQualitySet, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemLevelSelectorQualitySet : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public short? IlvlRare;
        
        [DBFieldName("CHANGEME")]
        public short? IlvlEpic;
    }
}
