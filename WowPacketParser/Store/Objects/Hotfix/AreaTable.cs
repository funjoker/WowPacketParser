using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.AreaTable, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class AreaTable : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string ZoneName;
        
        [DBFieldName("CHANGEME")]
        public string AreaName;
        
        [DBFieldName("CHANGEME")]
        public ushort? ContinentID;
        
        [DBFieldName("CHANGEME")]
        public ushort? ParentAreaID;
        
        [DBFieldName("CHANGEME")]
        public short? AreaBit;
        
        [DBFieldName("CHANGEME")]
        public byte? SoundProviderPref;
        
        [DBFieldName("CHANGEME")]
        public byte? SoundProviderPrefUnderwater;
        
        [DBFieldName("CHANGEME")]
        public ushort? AmbienceID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UwAmbience;
        
        [DBFieldName("CHANGEME")]
        public ushort? ZoneMusic;
        
        [DBFieldName("CHANGEME")]
        public ushort? UwZoneMusic;
        
        [DBFieldName("CHANGEME")]
        public sbyte? ExplorationLevel;
        
        [DBFieldName("CHANGEME")]
        public ushort? IntroSound;
        
        [DBFieldName("CHANGEME")]
        public uint? UwIntroSound;
        
        [DBFieldName("CHANGEME")]
        public byte? FactionGroupMask;
        
        [DBFieldName("CHANGEME")]
        public float? AmbientMultiplier;
        
        [DBFieldName("CHANGEME")]
        public byte? MountFlags;
        
        [DBFieldName("CHANGEME")]
        public short? PvpCombatWorldStateID;
        
        [DBFieldName("CHANGEME")]
        public byte? WildBattlePetLevelMin;
        
        [DBFieldName("CHANGEME")]
        public byte? WildBattlePetLevelMax;
        
        [DBFieldName("CHANGEME")]
        public byte? WindSettingsID;
        
        [HotfixArray(2)]
        public int?[] Flags;
        
        [HotfixArray(4)]
        public ushort?[] LiquidTypeID;
    }
}
