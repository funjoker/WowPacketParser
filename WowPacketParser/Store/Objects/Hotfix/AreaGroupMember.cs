using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AreaGroupMember, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AreaGroupMember : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? AreaID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AreaGroupID;
    }
}
