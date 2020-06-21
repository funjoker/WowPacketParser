using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BannedAddOns, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class BannedAddOns : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Version;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
