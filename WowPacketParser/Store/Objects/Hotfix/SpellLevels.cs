using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellLevels, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellLevels : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public short? BaseLevel;
        
        [DBFieldName("CHANGEME")]
        public short? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public short? SpellLevel;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPassiveAuraLevel;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
