using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellCategories, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellCategories : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public short? Category;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DefenseType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DispelType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Mechanic;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PreventionType;
        
        [DBFieldName("CHANGEME")]
        public short? StartRecoveryCategory;
        
        [DBFieldName("CHANGEME")]
        public short? ChargeCategory;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
