using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.MountXDisplay, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class MountXDisplay : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? CreatureDisplayInfoID;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public int? MountID;
    }
}
