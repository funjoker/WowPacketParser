using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TaxiNodes, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_5_29683)]
    [DBTableName("CHANGEME")]
    public sealed class TaxiNodes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(3)]
        public float?[] Pos;
        
        [HotfixArray(2)]
        public float?[] MapOffset;
        
        [HotfixArray(2)]
        public float?[] FlightMapOffset;
        
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CharacterBitNumber;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? UiTextureKitID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_0_28724, false)]
        public int? MinimapAtlasMemberID;
        
        [DBFieldName("CHANGEME")]
        public float? Facing;
        
        [DBFieldName("CHANGEME")]
        public uint? SpecialIconConditionID;
        
        [DBFieldName("CHANGEME")]
        public uint? VisibilityConditionID;
        
        [HotfixArray(2)]
        public int?[] MountCreatureID;
    }
}
