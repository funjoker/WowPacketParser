using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ChrRaces)]
    [DBTableName("CHANGEME")]
    public sealed class ChrRaces : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string ClientPrefix;
        
        [DBFieldName("CHANGEME")]
        public string ClientFileString;
        
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string NameFemale;
        
        [DBFieldName("CHANGEME")]
        public string NameLowercase;
        
        [DBFieldName("CHANGEME")]
        public string NameFemaleLowercase;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? Flags;
        
        [DBFieldName("CHANGEME")]
        public uint? MaleDisplayId;
        
        [DBFieldName("CHANGEME")]
        public uint? FemaleDisplayId;
        
        [DBFieldName("CHANGEME")]
        public uint? HighResMaleDisplayId;
        
        [DBFieldName("CHANGEME")]
        public uint? HighResFemaleDisplayId;
        
        [DBFieldName("CHANGEME")]
        public int? CreateScreenFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? SelectScreenFileDataID;
        
        [HotfixArray(3)]
        public float?[] MaleCustomizeOffset;
        
        [HotfixArray(3)]
        public float?[] FemaleCustomizeOffset;
        
        [DBFieldName("CHANGEME")]
        public int? LowResScreenFileDataID;
        
        [HotfixArray(3)]
        public uint?[] AlteredFormStartVisualKitID;
        
        [HotfixArray(3)]
        public uint?[] AlteredFormFinishVisualKitID;
        
        [DBFieldName("CHANGEME")]
        public int? HeritageArmorAchievementID;
        
        [DBFieldName("CHANGEME")]
        public int? StartingLevel;
        
        [DBFieldName("CHANGEME")]
        public int? UiDisplayOrder;
        
        [DBFieldName("CHANGEME")]
        public int? FemaleSkeletonFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? MaleSkeletonFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? HelmVisFallbackRaceID;
        
        [HotfixVersion(ClientVersionBuild.V8_3_0_33062, false)]
        public int? TransmogrifyDisabledSlotMask;
        
        [DBFieldName("CHANGEME")]
        public short? FactionID;
        
        [DBFieldName("CHANGEME")]
        public short? CinematicSequenceID;
        
        [DBFieldName("CHANGEME")]
        public short? ResSicknessSpellID;
        
        [DBFieldName("CHANGEME")]
        public short? SplashSoundID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? BaseLanguage;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CreatureType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Alliance;
        
        [DBFieldName("CHANGEME")]
        public sbyte? RaceRelated;
        
        [DBFieldName("CHANGEME")]
        public sbyte? UnalteredVisualRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CharComponentTextureLayoutID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CharComponentTexLayoutHiResID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DefaultClassID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? NeutralRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaleModelFallbackRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaleModelFallbackSex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FemaleModelFallbackRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FemaleModelFallbackSex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaleTextureFallbackRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaleTextureFallbackSex;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FemaleTextureFallbackRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FemaleTextureFallbackSex;
    }
}
