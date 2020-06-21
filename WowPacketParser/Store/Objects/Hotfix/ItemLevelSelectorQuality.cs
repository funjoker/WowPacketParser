using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemLevelSelectorQuality, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemLevelSelectorQuality : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? QualityItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Quality;
        
        [DBFieldName("CHANGEME")]
        public short? ParentILSQualitySetID;
    }
}
