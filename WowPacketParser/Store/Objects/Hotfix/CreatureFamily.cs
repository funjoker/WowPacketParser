using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CreatureFamily, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CreatureFamily : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public float? MinScale;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinScaleLevel;
        
        [DBFieldName("CHANGEME")]
        public float? MaxScale;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MaxScaleLevel;
        
        [DBFieldName("CHANGEME")]
        public short? PetFoodMask;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PetTalentType;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileID;
        
        [HotfixArray(2)]
        public short?[] SkillLine;
    }
}
