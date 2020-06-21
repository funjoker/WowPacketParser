using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GameObjects)]
    [DBTableName("CHANGEME")]
    public sealed class GameObjects : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(3, true)]
        public float?[] Pos;
        
        [HotfixArray(4)]
        public float?[] Rot;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? OwnerID;
        
        [DBFieldName("CHANGEME")]
        public ushort? DisplayID;
        
        [DBFieldName("CHANGEME")]
        public float? Scale;
        
        [DBFieldName("CHANGEME")]
        public byte? TypeID;
        
        [DBFieldName("CHANGEME")]
        public byte? PhaseUseFlags;
        
        [DBFieldName("CHANGEME")]
        public ushort? PhaseID;
        
        [DBFieldName("CHANGEME")]
        public ushort? PhaseGroupID;
        
        [HotfixArray(8)]
        public int?[] PropValue;
    }
}
