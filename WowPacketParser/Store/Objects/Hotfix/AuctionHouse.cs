using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AuctionHouse, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AuctionHouse : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public ushort? FactionID;
        
        [DBFieldName("CHANGEME")]
        public byte? DepositRate;
        
        [DBFieldName("CHANGEME")]
        public byte? ConsignmentRate;
    }
}
