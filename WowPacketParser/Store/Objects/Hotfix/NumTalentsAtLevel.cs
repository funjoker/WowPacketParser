using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.NumTalentsAtLevel)]
    [DBTableName("CHANGEME")]
    public sealed class NumTalentsAtLevel : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? NumTalents;
        
        [DBFieldName("CHANGEME")]
        public int? NumTalentsDeathKnight;
        
        [DBFieldName("CHANGEME")]
        public int? NumTalentsDemonHunter;
    }
}
