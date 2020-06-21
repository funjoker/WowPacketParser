using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellFocusObject, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellFocusObject : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
    }
}
