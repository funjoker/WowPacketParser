using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParserModule.V8_2_5_31921.Hotfix
{
    [HotfixStructure(DB2Hash.PowerType, ClientVersionBuild.V8_2_5_31921)]
    [DBTableName("CHANGEME")]
    public sealed class PowerType : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string NameGlobalStringTag;
        
        [DBFieldName("CHANGEME")]
        public string CostGlobalStringTag;
        
        [DBFieldName("CHANGEME")]
        public uint? ID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? PowerTypeEnum;
        
        [DBFieldName("CHANGEME")]
        public sbyte? MinPower;
        
        [DBFieldName("CHANGEME")]
        public short? MaxBasePower;
        
        [DBFieldName("CHANGEME")]
        public sbyte? CenterPower;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DefaultPower;
        
        [DBFieldName("CHANGEME")]
        public sbyte? DisplayModifier;
        
        [DBFieldName("CHANGEME")]
        public short? RegenInterruptTimeMS;
        
        [DBFieldName("CHANGEME")]
        public float? RegenPeace;
        
        [DBFieldName("CHANGEME")]
        public float? RegenCombat;
        
        [DBFieldName("CHANGEME")]
        public short? Flags;
    }
}
