using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PhaseXPhaseGroup, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PhaseXPhaseGroup : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? PhaseID;
        
        [DBFieldName("CHANGEME")]
        public ushort? PhaseGroupID;
    }
}
