using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PvpTalentSlotUnlock, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PvpTalentSlotUnlock : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? Slot;
        
        [DBFieldName("CHANGEME")]
        public int? LevelRequired;
        
        [DBFieldName("CHANGEME")]
        public int? DeathKnightLevelRequired;
        
        [DBFieldName("CHANGEME")]
        public int? DemonHunterLevelRequired;
    }
}
