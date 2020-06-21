using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.WorldEffect, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class WorldEffect : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? QuestFeedbackEffectID;
        
        [DBFieldName("CHANGEME")]
        public byte? WhenToDisplay;
        
        [DBFieldName("CHANGEME")]
        public sbyte? TargetType;
        
        [DBFieldName("CHANGEME")]
        public int? TargetAsset;
        
        [DBFieldName("CHANGEME")]
        public uint? PlayerConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CombatConditionID;
    }
}
