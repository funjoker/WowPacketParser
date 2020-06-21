using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.LiquidType, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class LiquidType : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [HotfixArray(6)]
        public string[] Texture;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public byte? SoundBank;
        
        [DBFieldName("CHANGEME")]
        public uint? SoundID;
        
        [DBFieldName("CHANGEME")]
        public uint? SpellID;
        
        [DBFieldName("CHANGEME")]
        public float? MaxDarkenDepth;
        
        [DBFieldName("CHANGEME")]
        public float? FogDarkenIntensity;
        
        [DBFieldName("CHANGEME")]
        public float? AmbDarkenIntensity;
        
        [DBFieldName("CHANGEME")]
        public float? DirDarkenIntensity;
        
        [DBFieldName("CHANGEME")]
        public ushort? LightID;
        
        [DBFieldName("CHANGEME")]
        public float? ParticleScale;
        
        [DBFieldName("CHANGEME")]
        public byte? ParticleMovement;
        
        [DBFieldName("CHANGEME")]
        public byte? ParticleTexSlots;
        
        [DBFieldName("CHANGEME")]
        public byte? MaterialID;
        
        [DBFieldName("CHANGEME")]
        public int? MinimapStaticCol;
        
        [HotfixArray(6)]
        public byte?[] FrameCountTexture;
        
        [HotfixArray(2)]
        public int?[] Color;
        
        [HotfixArray(18)]
        public float?[] Float;
        
        [HotfixArray(4)]
        public uint?[] Int;
        
        [HotfixArray(4)]
        public float?[] Coefficient;
    }
}
