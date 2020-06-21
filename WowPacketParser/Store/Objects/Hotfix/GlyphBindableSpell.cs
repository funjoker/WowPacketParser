using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GlyphBindableSpell, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GlyphBindableSpell : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public short? GlyphPropertiesID;
    }
}
