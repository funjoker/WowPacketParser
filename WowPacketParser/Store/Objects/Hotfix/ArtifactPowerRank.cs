using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactPowerRank, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactPowerRank : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? RankIndex;
        
        [DBFieldName("CHANGEME")]
        public int? SpellID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public float? AuraPointsOverride;
        
        [DBFieldName("CHANGEME")]
        public ushort? ArtifactPowerID;
    }
}
