using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrPlot, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrPlot : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public byte? PlotType;
        
        [DBFieldName("CHANGEME")]
        public int? HordeConstructObjID;
        
        [DBFieldName("CHANGEME")]
        public int? AllianceConstructObjID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? UiCategoryID;
        
        [HotfixArray(2)]
        public uint?[] UpgradeRequirement;
    }
}
