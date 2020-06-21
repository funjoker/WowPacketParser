using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellCooldowns, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellCooldowns : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public int? CategoryRecoveryTime;
        
        [DBFieldName("CHANGEME")]
        public int? RecoveryTime;
        
        [DBFieldName("CHANGEME")]
        public int? StartRecoveryTime;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
    }
}
