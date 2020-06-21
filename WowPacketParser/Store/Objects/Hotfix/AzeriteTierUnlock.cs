using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteTierUnlock, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteTierUnlock : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? ItemCreationContext;
        
        [DBFieldName("CHANGEME")]
        public byte? Tier;
        
        [DBFieldName("CHANGEME")]
        public byte? AzeriteLevel;
        
        [DBFieldName("CHANGEME")]
        public uint? AzeriteTierUnlockSetID;
    }
}
