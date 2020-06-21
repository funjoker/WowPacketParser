using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Heirloom, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_5_29683)]
    [DBTableName("CHANGEME")]
    public sealed class Heirloom : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string SourceText;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? ItemID;
        
        [DBFieldName("CHANGEME")]
        public int? LegacyUpgradedItemID;
        
        [DBFieldName("CHANGEME")]
        public int? StaticUpgradedItemID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SourceTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? LegacyItemID;
        
        [HotfixArray(3)]
        public int?[] UpgradeItemID;
        
        [HotfixArray(3)]
        public ushort?[] UpgradeItemBonusListID;
    }
}
