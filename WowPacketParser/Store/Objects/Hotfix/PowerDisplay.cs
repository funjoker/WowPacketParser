using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PowerDisplay, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PowerDisplay : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string GlobalStringBaseTag;
        
        [DBFieldName("CHANGEME")]
        public byte? ActualType;
        
        [DBFieldName("CHANGEME")]
        public byte? Red;
        
        [DBFieldName("CHANGEME")]
        public byte? Green;
        
        [DBFieldName("CHANGEME")]
        public byte? Blue;
    }
}
