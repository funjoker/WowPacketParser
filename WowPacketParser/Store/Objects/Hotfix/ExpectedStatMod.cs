using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ExpectedStatMod, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ExpectedStatMod : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public float? CreatureHealthMod;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerHealthMod;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureAutoAttackDPSMod;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureArmorMod;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerManaMod;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerPrimaryStatMod;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerSecondaryStatMod;
        
        [DBFieldName("CHANGEME")]
        public float? ArmorConstantMod;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureSpellDamageMod;
    }
}
