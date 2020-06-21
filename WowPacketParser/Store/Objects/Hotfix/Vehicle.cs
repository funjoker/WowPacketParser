using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Vehicle, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Vehicle : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? FlagsB;
        
        [DBFieldName("CHANGEME")]
        public float? TurnSpeed;
        
        [DBFieldName("CHANGEME")]
        public float? PitchSpeed;
        
        [DBFieldName("CHANGEME")]
        public float? PitchMin;
        
        [DBFieldName("CHANGEME")]
        public float? PitchMax;
        
        [DBFieldName("CHANGEME")]
        public float? MouseLookOffsetPitch;
        
        [DBFieldName("CHANGEME")]
        public float? CameraFadeDistScalarMin;
        
        [DBFieldName("CHANGEME")]
        public float? CameraFadeDistScalarMax;
        
        [DBFieldName("CHANGEME")]
        public float? CameraPitchOffset;
        
        [DBFieldName("CHANGEME")]
        public float? FacingLimitRight;
        
        [DBFieldName("CHANGEME")]
        public float? FacingLimitLeft;
        
        [DBFieldName("CHANGEME")]
        public float? CameraYawOffset;
        
        [DBFieldName("CHANGEME")]
        public byte? UiLocomotionType;
        
        [DBFieldName("CHANGEME")]
        public ushort? VehicleUIIndicatorID;
        
        [DBFieldName("CHANGEME")]
        public int? MissileTargetingID;
        
        [HotfixArray(8)]
        public ushort?[] SeatID;
        
        [HotfixArray(3)]
        public ushort?[] PowerDisplayID;
    }
}
