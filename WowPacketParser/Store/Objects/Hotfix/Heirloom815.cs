using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_5_29683.Hotfix
{
    [HotfixStructure(DB2Hash.Heirloom, ClientVersionBuild.V8_1_5_29683)]
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
        
        [HotfixArray(4)]
        public int?[] UpgradeItemID;
        
        [HotfixArray(4)]
        public ushort?[] UpgradeItemBonusListID;
    }
}
