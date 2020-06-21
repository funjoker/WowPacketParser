using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.WMOAreaTable)]
    [DBTableName("CHANGEME")]
    public sealed class WMOAreaTable : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string AreaName;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? WmoID;
        
        [DBFieldName("CHANGEME")]
        public byte? NameSetID;
        
        [DBFieldName("CHANGEME")]
        public int? WmoGroupID;
        
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
        public uint? UwZoneMusic;
        
        [DBFieldName("CHANGEME")]
        public ushort? IntroSound;
        
        [DBFieldName("CHANGEME")]
        public ushort? UwIntroSound;
        
        [DBFieldName("CHANGEME")]
        public ushort? AreaTableID;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
