using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.BattlePetSpecies)]
    [DBTableName("CHANGEME")]
    public sealed class BattlePetSpecies : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Description;
        
        [DBFieldName("CHANGEME")]
        public string SourceText;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public int? CreatureID;
        
        [DBFieldName("CHANGEME")]
        public int? SummonSpellID;
        
        [DBFieldName("CHANGEME")]
        public int? IconFileDataID;
        
        [DBFieldName("CHANGEME")]
        public byte? PetTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public ushort? Flags;
        
        [DBFieldName("CHANGEME")]
        public sbyte? SourceTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public int? CardUIModelSceneID;
        
        [DBFieldName("CHANGEME")]
        public int? LoadoutUIModelSceneID;
    }
}
