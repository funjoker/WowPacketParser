using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteUnlockMapping, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteUnlockMapping : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ItemLevel;
        
        [DBFieldName("CHANGEME")]
        public int? ItemBonusListHead;
        
        [DBFieldName("CHANGEME")]
        public int? ItemBonusListShoulders;
        
        [DBFieldName("CHANGEME")]
        public int? ItemBonusListChest;
        
        [DBFieldName("CHANGEME")]
        public uint? AzeriteUnlockMappingSetID;
    }
}
