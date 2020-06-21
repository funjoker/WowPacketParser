using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfoExtra, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CreatureDisplayInfoExtra : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? DisplayRaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DisplaySexID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DisplayClassID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SkinID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FaceID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? HairStyleID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? HairColorID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? FacialHairID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? Flags;
        
        [DBFieldName("CHANGEME")]
        public int? BakeMaterialResourcesID;
        
        [DBFieldName("CHANGEME")]
        public int? HDBakeMaterialResourcesID;
        
        [HotfixArray(3)]
        public byte?[] CustomDisplayOption;
    }
}
