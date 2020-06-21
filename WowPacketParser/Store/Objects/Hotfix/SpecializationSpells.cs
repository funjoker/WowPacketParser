using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpecializationSpells)]
    [DBTableName("CHANGEME")]
    public sealed class SpecializationSpells : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpecID;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public int? OverridesSpellID;
        
        [DBFieldName("CHANGEME")]
        public byte? DisplayOrder;
    }
}
