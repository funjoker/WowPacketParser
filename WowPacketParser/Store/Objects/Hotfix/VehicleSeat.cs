using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.VehicleSeat, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class VehicleSeat : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] AttachmentOffset;
        
        [HotfixArray(3, true)]
        public float?[] CameraOffset;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? FlagsB;
        
        [DBFieldName("CHANGEME")]
        public int? FlagsC;
        
        [DBFieldName("CHANGEME")]
        public sbyte? AttachmentID;
        
        [DBFieldName("CHANGEME")]
        public float? EnterPreDelay;
        
        [DBFieldName("CHANGEME")]
        public float? EnterSpeed;
        
        [DBFieldName("CHANGEME")]
        public float? EnterGravity;
        
        [DBFieldName("CHANGEME")]
        public float? EnterMinDuration;
        
        [DBFieldName("CHANGEME")]
        public float? EnterMaxDuration;
        
        [DBFieldName("CHANGEME")]
        public float? EnterMinArcHeight;
        
        [DBFieldName("CHANGEME")]
        public float? EnterMaxArcHeight;
        
        [DBFieldName("CHANGEME")]
        public int? EnterAnimStart;
        
        [DBFieldName("CHANGEME")]
        public int? EnterAnimLoop;
        
        [DBFieldName("CHANGEME")]
        public int? RideAnimStart;
        
        [DBFieldName("CHANGEME")]
        public int? RideAnimLoop;
        
        [DBFieldName("CHANGEME")]
        public int? RideUpperAnimStart;
        
        [DBFieldName("CHANGEME")]
        public int? RideUpperAnimLoop;
        
        [DBFieldName("CHANGEME")]
        public float? ExitPreDelay;
        
        [DBFieldName("CHANGEME")]
        public float? ExitSpeed;
        
        [DBFieldName("CHANGEME")]
        public float? ExitGravity;
        
        [DBFieldName("CHANGEME")]
        public float? ExitMinDuration;
        
        [DBFieldName("CHANGEME")]
        public float? ExitMaxDuration;
        
        [DBFieldName("CHANGEME")]
        public float? ExitMinArcHeight;
        
        [DBFieldName("CHANGEME")]
        public float? ExitMaxArcHeight;
        
        [DBFieldName("CHANGEME")]
        public int? ExitAnimStart;
        
        [DBFieldName("CHANGEME")]
        public int? ExitAnimLoop;
        
        [DBFieldName("CHANGEME")]
        public int? ExitAnimEnd;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleEnterAnim;
        
        [DBFieldName("CHANGEME")]
        public sbyte? VehicleEnterAnimBone;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleExitAnim;
        
        [DBFieldName("CHANGEME")]
        public sbyte? VehicleExitAnimBone;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleRideAnimLoop;
        
        [DBFieldName("CHANGEME")]
        public sbyte? VehicleRideAnimLoopBone;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PassengerAttachmentID;
        
        [DBFieldName("CHANGEME")]
        public float? PassengerYaw;
        
        [DBFieldName("CHANGEME")]
        public float? PassengerPitch;
        
        [DBFieldName("CHANGEME")]
        public float? PassengerRoll;
        
        [DBFieldName("CHANGEME")]
        public float? VehicleEnterAnimDelay;
        
        [DBFieldName("CHANGEME")]
        public float? VehicleExitAnimDelay;
        
        [DBFieldName("CHANGEME")]
        public sbyte? VehicleAbilityDisplay;
        
        [DBFieldName("CHANGEME")]
        public uint? EnterUISoundID;
        
        [DBFieldName("CHANGEME")]
        public uint? ExitUISoundID;
        
        [DBFieldName("CHANGEME")]
        public int? UiSkinFileDataID;
        
        [DBFieldName("CHANGEME")]
        public float? CameraEnteringDelay;
        
        [DBFieldName("CHANGEME")]
        public float? CameraEnteringDuration;
        
        [DBFieldName("CHANGEME")]
        public float? CameraExitingDelay;
        
        [DBFieldName("CHANGEME")]
        public float? CameraExitingDuration;
        
        [DBFieldName("CHANGEME")]
        public float? CameraPosChaseRate;
        
        [DBFieldName("CHANGEME")]
        public float? CameraFacingChaseRate;
        
        [DBFieldName("CHANGEME")]
        public float? CameraEnteringZoom;
        
        [DBFieldName("CHANGEME")]
        public float? CameraSeatZoomMin;
        
        [DBFieldName("CHANGEME")]
        public float? CameraSeatZoomMax;
        
        [DBFieldName("CHANGEME")]
        public short? EnterAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? RideAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? ExitAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleEnterAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleRideAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? VehicleExitAnimKitID;
        
        [DBFieldName("CHANGEME")]
        public short? CameraModeID;
    }
}
