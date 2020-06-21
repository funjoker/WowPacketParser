using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemDisenchantLoot, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemDisenchantLoot : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? Subclass;
        
        [DBFieldName("CHANGEME")]
        public byte? Quality;
        
        [DBFieldName("CHANGEME")]
        public ushort? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? MaxLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? SkillRequired;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ExpansionID;
        
        [DBFieldName("CHANGEME")]
        public byte? Class;
    }
}
