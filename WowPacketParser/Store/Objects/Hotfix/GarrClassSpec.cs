using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.GarrClassSpec)]
    [DBTableName("CHANGEME")]
    public sealed class GarrClassSpec : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string ClassSpec;
        
        [DBFieldName("CHANGEME")]
        public string ClassSpecMale;
        
        [DBFieldName("CHANGEME")]
        public string ClassSpecFemale;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public ushort? UiTextureAtlasMemberID;
        
        [DBFieldName("CHANGEME")]
        public ushort? GarrFollItemSetID;
        
        [DBFieldName("CHANGEME")]
        public byte? FollowerClassLimit;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
    }
}
