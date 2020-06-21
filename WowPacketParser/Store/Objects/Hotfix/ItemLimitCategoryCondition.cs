using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemLimitCategoryCondition, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemLimitCategoryCondition : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? AddQuantity;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public int? ParentItemLimitCategoryID;
    }
}
