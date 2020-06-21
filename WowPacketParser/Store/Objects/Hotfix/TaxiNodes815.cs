using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_1_5_29683.Hotfix
{
    [HotfixStructure(DB2Hash.TaxiNodes, ClientVersionBuild.V8_1_5_29683)]
    [DBTableName("CHANGEME")]
    public sealed class TaxiNodes : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(3, true)]
        public float?[] Pos;
        
        [HotfixArray(2, true)]
        public float?[] MapOffset;
        
        [HotfixArray(2, true)]
        public float?[] FlightMapOffset;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public int? ConditionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? CharacterBitNumber;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? UiTextureKitID;
        
        [DBFieldName("CHANGEME")]
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
