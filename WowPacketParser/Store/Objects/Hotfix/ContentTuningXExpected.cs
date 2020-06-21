using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ContentTuningXExpected, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ContentTuningXExpected : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ExpectedStatModID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? MythicPlusSeasonID;
        
        [DBFieldName("CHANGEME")]
        public int? ContentTuningID;
    }
}
