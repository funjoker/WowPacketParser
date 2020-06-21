using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Talent, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Talent : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public byte? TierID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? ColumnIndex;
        
        [DBFieldName("CHANGEME")]
        public byte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpecID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellID;
        
        [DBFieldName("CHANGEME")]
        public uint? OverridesSpellID;
        
        [HotfixArray(2)]
        public byte?[] CategoryMask;
    }
}
