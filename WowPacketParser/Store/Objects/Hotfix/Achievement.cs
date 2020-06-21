using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("achievement")]
    public sealed class Achievement : IDataModel
    {
        [DBFieldName("Description")]
        public string Description;
        
        [DBFieldName("Title")]
        public string Title;
        
        [DBFieldName("Reward")]
        public string Reward;
        
        [DBFieldName("ID", true)]
        public uint? ID;
        
        [DBFieldName("InstanceID")]
        public short? InstanceID;
        
        [DBFieldName("Faction")]
        public sbyte? Faction;
        
        [DBFieldName("Supercedes")]
        public short? Supercedes;
        
        [DBFieldName("Category")]
        public short? Category;
        
        [DBFieldName("MinimumCriteria")]
        public sbyte? MinimumCriteria;
        
        [DBFieldName("Points")]
        public sbyte? Points;
        
        [DBFieldName("Flags")]
        public int? Flags;
        
        [DBFieldName("UiOrder")]
        public short? UiOrder;
        
        [DBFieldName("IconFileID")]
        public int? IconFileID;
        
        [DBFieldName("RewardItemID")]
        public int? RewardItemID;
        
        [DBFieldName("CriteriaTree")]
        public uint? CriteriaTree;
        
        [DBFieldName("SharesCriteria")]
        public short? SharesCriteria;
    }
}
