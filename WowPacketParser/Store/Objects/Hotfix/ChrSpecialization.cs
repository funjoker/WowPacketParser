using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ChrSpecialization)]
    [DBTableName("CHANGEME")]
    public sealed class ChrSpecialization : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string FemaleName;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PetTalentType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Role;
        
        [DBFieldName("CHANGEME")]
        public uint? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? SpellIconFileID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PrimaryStatPriority;
        
        [DBFieldName("CHANGEME")]
        public int? AnimReplacements;
        
        [HotfixArray(2)]
        public int?[] MasterySpellID;
    }
}
