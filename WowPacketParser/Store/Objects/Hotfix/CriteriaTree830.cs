using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_3_0_33062.Hotfix
{
    [HotfixStructure(DB2Hash.CriteriaTree, ClientVersionBuild.V8_3_0_33062, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CriteriaTree : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? Parent;
        
        [DBFieldName("CHANGEME")]
        public uint? Amount;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Operator;
        
        [DBFieldName("CHANGEME")]
        public uint? CriteriaID;
        
        [DBFieldName("CHANGEME")]
        public int? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
    }
}
