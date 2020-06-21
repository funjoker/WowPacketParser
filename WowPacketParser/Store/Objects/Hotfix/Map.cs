using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Map, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Map : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Directory;
        
        [DBFieldName("CHANGEME")]
        public string MapName;
        
        [DBFieldName("CHANGEME")]
        public string MapDescription0;
        
        [DBFieldName("CHANGEME")]
        public string MapDescription1;
        
        [DBFieldName("CHANGEME")]
        public string PvpShortDescription;
        
        [DBFieldName("CHANGEME")]
        public string PvpLongDescription;
        
        [HotfixArray(2, true)]
        public float?[] Corpse;
        
        [DBFieldName("CHANGEME")]
        public byte? MapType;
        
        [DBFieldName("CHANGEME")]
        public sbyte? InstanceType;
        
        [DBFieldName("CHANGEME")]
        public byte? ExpansionID;
        
        [DBFieldName("CHANGEME")]
        public ushort? AreaTableID;
        
        [DBFieldName("CHANGEME")]
        public short? LoadingScreenID;
        
        [DBFieldName("CHANGEME")]
        public short? TimeOfDayOverride;
        
        [DBFieldName("CHANGEME")]
        public short? ParentMapID;
        
        [DBFieldName("CHANGEME")]
        public short? CosmeticParentMapID;
        
        [DBFieldName("CHANGEME")]
        public byte? TimeOffset;
        
        [DBFieldName("CHANGEME")]
        public float? MinimapIconScale;
        
        [DBFieldName("CHANGEME")]
        public short? CorpseMapID;
        
        [DBFieldName("CHANGEME")]
        public byte? MaxPlayers;
        
        [DBFieldName("CHANGEME")]
        public short? WindSettingsID;
        
        [DBFieldName("CHANGEME")]
        public int? ZmpFileDataID;
        
        [HotfixVersion(ClientVersionBuild.V8_1_5_29683, false)]
        public int? WdtFileDataID;
        
        [HotfixArray(2)]
        public int?[] Flags;
    }
}
