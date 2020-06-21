using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellName, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellName : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
    }
}
