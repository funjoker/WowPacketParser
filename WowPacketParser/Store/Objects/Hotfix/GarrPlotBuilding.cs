using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrPlotBuilding, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrPlotBuilding : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? GarrPlotID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrBuildingID;
    }
}
