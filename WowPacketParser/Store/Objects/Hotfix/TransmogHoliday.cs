using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TransmogHoliday)]
    [DBTableName("CHANGEME")]
    public sealed class TransmogHoliday : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public int? RequiredTransmogHoliday;
    }
}
