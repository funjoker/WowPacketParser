using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GuildPerkSpells, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GuildPerkSpells : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
