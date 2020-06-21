using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellProcsPerMinute, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellProcsPerMinute : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? BaseProcRate;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
