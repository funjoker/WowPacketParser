using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_0_28724.Hotfix
{
    [HotfixStructure(DB2Hash.AzeritePowerSetMember, ClientVersionBuild.V8_1_0_28724, ClientVersionBuild.V8_2_0_30898, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeritePowerSetMember : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? AzeritePowerSetID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AzeritePowerID;
        
        [DBFieldName("CHANGEME")]
        public byte? Class;
        
        [DBFieldName("CHANGEME")]
        public byte? Tier;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
    }
}
