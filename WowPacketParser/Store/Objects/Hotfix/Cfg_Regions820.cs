using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_0_30898.Hotfix
{
    [HotfixStructure(DB2Hash.Cfg_Regions, ClientVersionBuild.V8_2_0_30898, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Cfg_Regions : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Tag;
        
        [DBFieldName("CHANGEME")]
        public ushort? RegionID;
        
        [DBFieldName("CHANGEME")]
        public uint? Raidorigin;
        
        [DBFieldName("CHANGEME")]
        public byte? RegionGroupMask;
        
        [DBFieldName("CHANGEME")]
        public uint? ChallengeOrigin;
    }
}
