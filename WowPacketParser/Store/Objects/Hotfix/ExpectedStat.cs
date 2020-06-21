using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ExpectedStat, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ExpectedStat : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ExpansionID;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureHealth;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerHealth;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureAutoAttackDps;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureArmor;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerMana;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerPrimaryStat;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerSecondaryStat;
        
        [DBFieldName("CHANGEME")]
        public float? ArmorConstant;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureSpellDamage;
        
        [DBFieldName("CHANGEME")]
        public int? Lvl;
    }
}
