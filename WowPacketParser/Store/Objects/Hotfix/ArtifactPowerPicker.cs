using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactPowerPicker, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactPowerPicker : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
    }
}
