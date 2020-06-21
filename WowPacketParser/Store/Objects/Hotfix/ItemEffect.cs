using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemEffect, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemEffect : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? LegacySlotIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? TriggerType;
        
        [DBFieldName("CHANGEME")]
        public short? Charges;
        
        [DBFieldName("CHANGEME")]
        public int? CoolDownMSec;
        
        [DBFieldName("CHANGEME")]
        public int? CategoryCoolDownMSec;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpellCategoryID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ChrSpecializationID;
        
        [DBFieldName("CHANGEME")]
        public int? ParentItemID;
    }
}
