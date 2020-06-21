using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TotemCategory, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class TotemCategory : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? TotemCategoryType;
        
        [DBFieldName("CHANGEME")]
        public int? TotemCategoryMask;
    }
}
