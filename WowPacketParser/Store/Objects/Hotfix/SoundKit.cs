using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SoundKit, ClientVersionBuild.V8_0_1_27101, ClientVersionBuild.V8_1_0_28724)]
    [DBTableName("CHANGEME")]
    public sealed class SoundKit : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? SoundType;
        
        [DBFieldName("CHANGEME")]
        public float? VolumeFloat;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public float? MinDistance;
        
        [DBFieldName("CHANGEME")]
        public float? DistanceCutoff;
        
        [DBFieldName("CHANGEME")]
        public byte? EAXDef;
        
        [DBFieldName("CHANGEME")]
        public uint? SoundKitAdvancedID;
        
        [DBFieldName("CHANGEME")]
        public float? VolumeVariationPlus;
        
        [DBFieldName("CHANGEME")]
        public float? VolumeVariationMinus;
        
        [DBFieldName("CHANGEME")]
        public float? PitchVariationPlus;
        
        [DBFieldName("CHANGEME")]
        public float? PitchVariationMinus;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DialogType;
        
        [DBFieldName("CHANGEME")]
        public float? PitchAdjust;
        
        [DBFieldName("CHANGEME")]
        public ushort? BusOverwriteID;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxInstances;
    }
}
