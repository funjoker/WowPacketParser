using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrPlotInstance, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrPlotInstance : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrPlotID;
    }
}
