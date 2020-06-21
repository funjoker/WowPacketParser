using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactPower)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactPower : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] DisplayPos;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactID;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPurchasableRank;
        
        [DBFieldName("CHANGEME")]
        public int? Label;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? Tier;
    }
}
