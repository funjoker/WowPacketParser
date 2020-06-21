using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Faction, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class Faction : IDataModel
    {
        [HotfixArray(4)]
        public ulong?[] ReputationRaceMask;
        
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public short? ReputationIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParentFactionID;
        
        [DBFieldName("CHANGEME")]
        public byte? Expansion;
        
        [DBFieldName("CHANGEME")]
        public byte? FriendshipRepID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParagonFactionID;
        
        [HotfixArray(4)]
        public short?[] ReputationClassMask;
        
        [HotfixArray(4)]
        public ushort?[] ReputationFlags;
        
        [HotfixArray(4)]
        public int?[] ReputationBase;
        
        [HotfixArray(4)]
        public int?[] ReputationMax;
        
        [HotfixArray(2)]
        public float?[] ParentFactionMod;
        
        [HotfixArray(2)]
        public byte?[] ParentFactionCap;
    }
}
