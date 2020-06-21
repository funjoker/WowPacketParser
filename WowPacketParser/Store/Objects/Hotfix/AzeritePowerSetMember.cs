using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AzeritePowerSetMember, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AzeritePowerSetMember : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? AzeritePowerID;
        
        [DBFieldName("CHANGEME")]
        public byte? Class;
        
        [DBFieldName("CHANGEME")]
        public byte? Tier;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? AzeritePowerSetID;
    }
}
