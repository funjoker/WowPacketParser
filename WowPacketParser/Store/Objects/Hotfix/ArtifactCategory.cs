using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactCategory, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactCategory : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public short? XpMultCurrencyID;
        
        [DBFieldName("CHANGEME")]
        public short? XpMultCurveID;
    }
}
