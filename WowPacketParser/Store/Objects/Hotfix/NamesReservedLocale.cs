using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.NamesReservedLocale, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class NamesReservedLocale : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? LocaleMask;
    }
}
