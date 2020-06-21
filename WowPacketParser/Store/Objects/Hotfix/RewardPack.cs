using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.RewardPack, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class RewardPack : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? CharTitleID;
        
        [DBFieldName("CHANGEME")]
        public uint? Money;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ArtifactXPDifficulty;
        
        [DBFieldName("CHANGEME")]
        public float? ArtifactXPMultiplier;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactXPCategoryID;
        
        [DBFieldName("CHANGEME")]
        public uint? TreasurePickerID;
    }
}
