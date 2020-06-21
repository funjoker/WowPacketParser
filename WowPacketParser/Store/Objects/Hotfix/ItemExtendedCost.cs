using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemExtendedCost, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemExtendedCost : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? RequiredArenaRating;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ArenaBracket;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? MinFactionID;
        
        [DBFieldName("CHANGEME")]
        public byte? MinReputation;
        
        [DBFieldName("CHANGEME")]
        public byte? RequiredAchievement;
        
        [HotfixArray(5)]
        public int?[] ItemID;
        
        [HotfixArray(5)]
        public ushort?[] ItemCount;
        
        [HotfixArray(5)]
        public ushort?[] CurrencyID;
        
        [HotfixArray(5)]
        public uint?[] CurrencyCount;
    }
}
