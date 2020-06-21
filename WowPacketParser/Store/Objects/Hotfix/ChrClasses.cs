using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.ChrClasses)]
    [DBTableName("CHANGEME")]
    public sealed class ChrClasses : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Filename;
        
        [DBFieldName("CHANGEME")]
        public string NameMale;
        
        [DBFieldName("CHANGEME")]
        public string NameFemale;
        
        [DBFieldName("CHANGEME")]
        public string PetNameToken;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public uint? CreateScreenFileDataID;
        
        [DBFieldName("CHANGEME")]
        public uint? SelectScreenFileDataID;
        
        [DBFieldName("CHANGEME")]
        public uint? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public uint? LowResScreenFileDataID;
        
        [DBFieldName("CHANGEME")]
        public int? StartingLevel;
        
        [HotfixVersion(ClientVersionBuild.V8_1_5_29683, false)]
        public uint? SpellTextureBlobFileDataID;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public ushort? CinematicSequenceID;
        
        [DBFieldName("CHANGEME")]
        public ushort? DefaultSpec;
        
        [DBFieldName("CHANGEME")]
        public byte? PrimaryStatPriority;
        
        [DBFieldName("CHANGEME")]
        public byte? DisplayPower;
        
        [DBFieldName("CHANGEME")]
        public byte? RangedAttackPowerPerAgility;
        
        [DBFieldName("CHANGEME")]
        public byte? AttackPowerPerAgility;
        
        [DBFieldName("CHANGEME")]
        public byte? AttackPowerPerStrength;
        
        [DBFieldName("CHANGEME")]
        public byte? SpellClassSet;
    }
}
