using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AreaTrigger)]
    [DBTableName("CHANGEME")]
    public sealed class AreaTrigger : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] Pos;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public short? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PhaseUseFlags;
        
        [DBFieldName("CHANGEME")]
        public short? PhaseID;
        
        [DBFieldName("CHANGEME")]
        public short? PhaseGroupID;
        
        [DBFieldName("CHANGEME")]
        public float? Radius;
        
        [DBFieldName("CHANGEME")]
        public float? BoxLength;
        
        [DBFieldName("CHANGEME")]
        public float? BoxWidth;
        
        [DBFieldName("CHANGEME")]
        public float? BoxHeight;
        
        [DBFieldName("CHANGEME")]
        public float? BoxYaw;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ShapeType;
        
        [DBFieldName("CHANGEME")]
        public short? ShapeID;
        
        [DBFieldName("CHANGEME")]
        public short? AreaTriggerActionSetID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
    }
}
