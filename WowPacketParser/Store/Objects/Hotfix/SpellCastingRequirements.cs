using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellCastingRequirements, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellCastingRequirements : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public byte? FacingCasterFlags;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinFactionID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinReputation;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredAreasID;
        
        [DBFieldName("CHANGEME")]
        public byte? RequiredAuraVision;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiresSpellFocus;
    }
}
