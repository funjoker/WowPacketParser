using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CreatureModelData, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CreatureModelData : IDataModel
    {
        [HotfixArray(6)]
        public float?[] GeoBox;
        
        [DBFieldName("CHANGEME")]
        public uint? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? FileDataID;
        
        [DBFieldName("CHANGEME")]
        public uint? BloodID;
        
        [DBFieldName("CHANGEME")]
        public uint? FootprintTextureID;
        
        [DBFieldName("CHANGEME")]
        public float? FootprintTextureLength;
        
        [DBFieldName("CHANGEME")]
        public float? FootprintTextureWidth;
        
        [DBFieldName("CHANGEME")]
        public float? FootprintParticleScale;
        
        [DBFieldName("CHANGEME")]
        public uint? FoleyMaterialID;
        
        [DBFieldName("CHANGEME")]
        public uint? FootstepCameraEffectID;
        
        [DBFieldName("CHANGEME")]
        public uint? DeathThudCameraEffectID;
        
        [DBFieldName("CHANGEME")]
        public uint? SoundID;
        
        [DBFieldName("CHANGEME")]
        public uint? SizeClass;
        
        [DBFieldName("CHANGEME")]
        public float? CollisionWidth;
        
        [DBFieldName("CHANGEME")]
        public float? CollisionHeight;
        
        [DBFieldName("CHANGEME")]
        public float? WorldEffectScale;
        
        [DBFieldName("CHANGEME")]
        public uint? CreatureGeosetDataID;
        
        [DBFieldName("CHANGEME")]
        public float? HoverHeight;
        
        [DBFieldName("CHANGEME")]
        public float? AttachedEffectScale;
        
        [DBFieldName("CHANGEME")]
        public float? ModelScale;
        
        [DBFieldName("CHANGEME")]
        public float? MissileCollisionRadius;
        
        [DBFieldName("CHANGEME")]
        public float? MissileCollisionPush;
        
        [DBFieldName("CHANGEME")]
        public float? MissileCollisionRaise;
        
        [DBFieldName("CHANGEME")]
        public float? MountHeight;
        
        [DBFieldName("CHANGEME")]
        public float? OverrideLootEffectScale;
        
        [DBFieldName("CHANGEME")]
        public float? OverrideNameScale;
        
        [DBFieldName("CHANGEME")]
        public float? OverrideSelectionRadius;
        
        [DBFieldName("CHANGEME")]
        public float? TamedPetBaseScale;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public byte? Unknown820_1;
        
        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        public float? Unknown820_2;

        [HotfixVersion(ClientVersionBuild.V8_2_0_30898, false)]
        [HotfixArray(2)]
        public float?[] Unknown820_3;
    }
}
