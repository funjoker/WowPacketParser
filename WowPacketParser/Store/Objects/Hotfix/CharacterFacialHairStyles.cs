using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CharacterFacialHairStyles, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CharacterFacialHairStyles : IDataModel
    {
        [HotfixArray(5)]
        public int?[] Geoset;
        
        [DBFieldName("CHANGEME")]
        public byte? RaceID;
        
        [DBFieldName("CHANGEME")]
        public byte? SexID;
        
        [DBFieldName("CHANGEME")]
        public byte? VariationID;
    }
}
