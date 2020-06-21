using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TransportAnimation, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class TransportAnimation : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] Pos;
        
        [DBFieldName("CHANGEME")]
        public byte? SequenceID;
        
        [DBFieldName("CHANGEME")]
        public uint? TimeIndex;
        
        [DBFieldName("CHANGEME")]
        public int? TransportID;
    }
}
