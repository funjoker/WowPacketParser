using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_0_30898.Hotfix
{
    [HotfixStructure(DB2Hash.AzeritePowerSetMember, ClientVersionBuild.V8_2_0_30898, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeritePowerSetMember : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? AzeritePowerSetID;
        
        [DBFieldName("CHANGEME")]
        public int? AzeritePowerID;
        
        [DBFieldName("CHANGEME")]
        public int? Class;
        
        [DBFieldName("CHANGEME")]
        public int? Tier;
        
        [DBFieldName("CHANGEME")]
        public int? OrderIndex;
    }
}
