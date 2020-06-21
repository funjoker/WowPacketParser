using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactTier, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactTier : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ArtifactTier;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxNumTraits;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxArtifactKnowledge;
        
        [DBFieldName("CHANGEME")]
        public uint? KnowledgePlayerCondition;
        
        [DBFieldName("CHANGEME")]
        public uint? MinimumEmpowerKnowledge;
    }
}
