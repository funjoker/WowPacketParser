using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrFollowerXAbility, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class GarrFollowerXAbility : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
        
        [DBFieldName("CHANGEME")]
        public byte? FactionIndex;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrAbilityID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrFollowerID;
    }
}
