using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.FactionTemplate, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class FactionTemplate : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? Faction;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? FactionGroup;
        
        [DBFieldName("CHANGEME")]
        public byte? FriendGroup;
        
        [DBFieldName("CHANGEME")]
        public byte? EnemyGroup;
        
        [HotfixArray(4)]
        public ushort?[] Enemies;
        
        [HotfixArray(4)]
        public ushort?[] Friend;
    }
}
