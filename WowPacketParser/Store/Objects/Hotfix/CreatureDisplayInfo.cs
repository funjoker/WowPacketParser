using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfo)]
    [DBTableName("CHANGEME")]
    public sealed class CreatureDisplayInfo : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ModelID;
        
        [DBFieldName("CHANGEME")]
        public ushort? SoundID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SizeClass;
        
        [DBFieldName("CHANGEME")]
        public float? CreatureModelScale;
        
        [DBFieldName("CHANGEME")]
        public byte? CreatureModelAlpha;
        
        [DBFieldName("CHANGEME")]
        public byte? BloodID;
        
        [DBFieldName("CHANGEME")]
        public int? ExtendedDisplayInfoID;
        
        [DBFieldName("CHANGEME")]
        public ushort? NPCSoundID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParticleColorID;
        
        [DBFieldName("CHANGEME")]
        public int? PortraitCreatureDisplayInfoID;
        
        [DBFieldName("CHANGEME")]
        public int? PortraitTextureFileDataID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ObjectEffectPackageID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AnimReplacementSetID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? StateSpellVisualKitID;
        
        [DBFieldName("CHANGEME")]
        public float? PlayerOverrideScale;
        
        [DBFieldName("CHANGEME")]
        public float? PetInstanceScale;
        
        [DBFieldName("CHANGEME")]
        public sbyte? UnarmedWeaponType;
        
        [DBFieldName("CHANGEME")]
        public int? MountPoofSpellVisualKitID;
        
        [DBFieldName("CHANGEME")]
        public int? DissolveEffectID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Gender;
        
        [DBFieldName("CHANGEME")]
        public int? DissolveOutEffectID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CreatureModelMinLod;
        
        [HotfixArray(3)]
        public int?[] TextureVariationFileDataID;
    }
}
