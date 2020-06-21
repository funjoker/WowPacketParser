using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.DungeonEncounter)]
    [DBTableName("CHANGEME")]
    public sealed class DungeonEncounter : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public short? MapID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DifficultyID;
        
        [DBFieldName("CHANGEME")]
        public int? OrderIndex;
        
        [HotfixVersion(ClientVersionBuild.V8_1_5_29683, false)]
        public int? CompleteWorldStateID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Bit;
        
        [DBFieldName("CHANGEME")]
        public int? CreatureDisplayID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? SpellIconFileID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public int? Faction;
    }
}
