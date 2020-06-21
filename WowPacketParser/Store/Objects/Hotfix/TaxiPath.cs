using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TaxiPath)]
    [DBTableName("CHANGEME")]
    public sealed class TaxiPath : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? FromTaxiNode;
        
        [DBFieldName("CHANGEME")]
        public ushort? ToTaxiNode;
        
        [DBFieldName("CHANGEME")]
        public uint? Cost;
    }
}
