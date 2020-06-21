using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SkillRaceClassInfo, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SkillRaceClassInfo : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public long? RaceMask;
        
        [DBFieldName("CHANGEME")]
        public short? SkillID;
        
        [DBFieldName("CHANGEME")]
        public int? ClassMask;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Availability;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinLevel;
        
        [DBFieldName("CHANGEME")]
        public short? SkillTierID;
    }
}
