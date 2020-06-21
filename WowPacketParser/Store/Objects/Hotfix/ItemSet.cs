using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ItemSet, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class ItemSet : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? SetFlags;
        
        [DBFieldName("CHANGEME")]
        public uint? RequiredSkill;
        
        [DBFieldName("CHANGEME")]
        public ushort? RequiredSkillRank;
        
        [HotfixArray(17)]
        public uint?[] ItemID;
    }
}
