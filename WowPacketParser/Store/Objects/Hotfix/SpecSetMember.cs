using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpecSetMember, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpecSetMember : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ChrSpecializationID;
        
        [DBFieldName("CHANGEME")]
        public int? SpecSetID;
    }
}
