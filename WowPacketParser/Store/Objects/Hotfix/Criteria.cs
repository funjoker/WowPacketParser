using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.Criteria, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class Criteria : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public short? Type;
        
        [DBFieldName("CHANGEME")]
        public int? Asset;
        
        [DBFieldName("CHANGEME")]
        public uint? ModifierTreeId;
        
        [DBFieldName("CHANGEME")]
        public byte? StartEvent;
        
        [DBFieldName("CHANGEME")]
        public int? StartAsset;
        
        [DBFieldName("CHANGEME")]
        public ushort? StartTimer;
        
        [DBFieldName("CHANGEME")]
        public byte? FailEvent;
        
        [DBFieldName("CHANGEME")]
        public int? FailAsset;
        
        [DBFieldName("CHANGEME")]
        public byte? Flags;
        
        [DBFieldName("CHANGEME")]
        public short? EligibilityWorldStateID;
        
        [DBFieldName("CHANGEME")]
        public sbyte? EligibilityWorldStateValue;
    }
}
