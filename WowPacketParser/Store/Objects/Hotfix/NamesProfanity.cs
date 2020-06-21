using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.NamesProfanity, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class NamesProfanity : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Language;
    }
}
