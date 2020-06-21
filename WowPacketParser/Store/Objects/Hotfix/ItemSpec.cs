using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemSpec, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSpec : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? ItemType;
        
        [DBFieldName("CHANGEME")]
        public byte? PrimaryStat;
        
        [DBFieldName("CHANGEME")]
        public byte? SecondaryStat;
        
        [DBFieldName("CHANGEME")]
        public ushort? SpecializationID;
    }
}
