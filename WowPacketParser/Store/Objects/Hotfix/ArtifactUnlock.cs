using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ArtifactUnlock, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ArtifactUnlock : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? PowerID;
        
        [DBFieldName("CHANGEME")]
        public byte? PowerRank;
        
        [DBFieldName("CHANGEME")]
        public ushort? ItemBonusListID;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public byte? ArtifactID;
    }
}
