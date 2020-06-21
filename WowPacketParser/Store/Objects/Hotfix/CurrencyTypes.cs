using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CurrencyTypes, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CurrencyTypes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public byte? CategoryID;
        
        [DBFieldName("CHANGEME")]
        public int? InventoryIconFileID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellWeight;
        
        [DBFieldName("CHANGEME")]
        public byte? SpellCategory;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxQty;
        
        [DBFieldName("CHANGEME")]
        public uint? MaxEarnablePerWeek;
        
        [DBFieldName("CHANGEME")]
        public uint? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Quality;
        
        [DBFieldName("CHANGEME")]
        public int? FactionID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_5_29683, false)]
        public int? ItemGroupSoundsID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? ConvertToPlayerExperience;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? PlayerConditionID;
    }
}
