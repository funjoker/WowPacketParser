using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AnimKit, HasIndexInData = false)]
    [DBTableName("anim_kit")]
    public sealed class AnimKit : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? OneShotDuration;
        
        [DBFieldName("CHANGEME")]
        public ushort? OneShotStopAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public ushort? LowDefAnimKitID;
    }
}
