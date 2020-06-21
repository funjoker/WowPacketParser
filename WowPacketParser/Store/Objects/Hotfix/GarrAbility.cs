using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrAbility)]
    [DBTableName("CHANGEME")]
    public sealed class GarrAbility : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrAbilityCategoryID;
        
        [DBFieldName("CHANGEME")]
        public byte? GarrFollowerTypeID;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public ushort? FactionChangeGarrAbilityID;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
    }
}
