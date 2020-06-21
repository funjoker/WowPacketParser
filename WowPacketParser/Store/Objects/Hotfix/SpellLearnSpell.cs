using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellLearnSpell, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellLearnSpell : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public int? LearnSpellID;
        
        [DBFieldName("CHANGEME")]
        public int? OverridesSpellID;
    }
}
