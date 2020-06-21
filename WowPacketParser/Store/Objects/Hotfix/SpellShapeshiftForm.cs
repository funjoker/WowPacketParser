using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellShapeshiftForm, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellShapeshiftForm : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CreatureType;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? AttackIconFileID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? BonusActionBar;
        
        [DBFieldName("CHANGEME")]
        public short? CombatRoundTime;
        
        [DBFieldName("CHANGEME")]
        public float? DamageVariance;
        
        [DBFieldName("CHANGEME")]
        public ushort? MountTypeID;
        
        [HotfixArray(4)]
        public uint?[] CreatureDisplayID;
        
        [HotfixArray(8)]
        public uint?[] PresetSpellID;
    }
}
