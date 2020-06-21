using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ModifierTree, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_2_0_30898, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ModifierTree : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? Parent;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Operator;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Amount;
        
        [DBFieldName("CHANGEME")]
        public byte? Type;
        
        [DBFieldName("CHANGEME")]
        public int? Asset;
        
        [DBFieldName("CHANGEME")]
        public int? SecondaryAsset;
        
        [DBFieldName("CHANGEME")]
        public sbyte? TertiaryAsset;
    }
}
