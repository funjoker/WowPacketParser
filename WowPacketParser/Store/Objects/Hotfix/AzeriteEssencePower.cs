using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeriteEssencePower, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeriteEssencePower : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string SourceAlliance;
        
        
        public string SourceHorde;
        
        
        public int? AzeriteEssenceID;
        
        
        public byte? Tier;
        
        
        public int? MajorPowerDescription;
        
        
        public int? MinorPowerDescription;
        
        
        public int? MajorPowerActual;
        
        
        public int? MinorPowerActual;
    }
}
