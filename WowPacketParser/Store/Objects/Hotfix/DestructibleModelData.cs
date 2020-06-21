using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.DestructibleModelData, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class DestructibleModelData : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public sbyte? State0ImpactEffectDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public byte? State0AmbientDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public ushort? State1Wmo;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State1DestructionDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State1ImpactEffectDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public byte? State1AmbientDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public ushort? State2Wmo;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State2DestructionDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State2ImpactEffectDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public byte? State2AmbientDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public ushort? State3Wmo;
        
        [DBFieldName("CHANGEME")]
        public byte? State3InitDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public byte? State3AmbientDoodadSet;
        
        [DBFieldName("CHANGEME")]
        public byte? EjectDirection;
        
        [DBFieldName("CHANGEME")]
        public byte? DoNotHighlight;
        
        [DBFieldName("CHANGEME")]
        public ushort? State0Wmo;
        
        [DBFieldName("CHANGEME")]
        public byte? HealEffect;
        
        [DBFieldName("CHANGEME")]
        public ushort? HealEffectSpeed;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State0NameSet;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State1NameSet;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State2NameSet;
        
        [DBFieldName("CHANGEME")]
        public sbyte? State3NameSet;
    }
}
