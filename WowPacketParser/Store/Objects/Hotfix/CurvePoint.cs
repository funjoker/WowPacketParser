using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CurvePoint, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CurvePoint : IDataModel
    {
        [HotfixArray(2, true)]
        public float?[] Pos;
        
        [DBFieldName("CHANGEME")]
        public ushort? CurveID;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
    }
}
