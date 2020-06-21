using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactPowerLink, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactPowerLink : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? PowerA;
        
        [DBFieldName("CHANGEME")]
        public ushort? PowerB;
    }
}
