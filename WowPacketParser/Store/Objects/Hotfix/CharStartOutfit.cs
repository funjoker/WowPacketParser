using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CharStartOutfit, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CharStartOutfit : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? ClassID;
        
        [DBFieldName("CHANGEME")]
        public byte? SexID;
        
        [DBFieldName("CHANGEME")]
        public byte? OutfitID;
        
        [DBFieldName("CHANGEME")]
        public uint? PetDisplayID;
        
        [DBFieldName("CHANGEME")]
        public byte? PetFamilyID;
        
        [HotfixArray(24)]
        public int?[] ItemID;
        
        [DBFieldName("CHANGEME")]
        public byte? RaceID;
    }
}
