using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.TransportRotation, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class TransportRotation : IDataModel
    {
        [HotfixArray(4)]
        public float?[] Rot;
        
        [DBFieldName("CHANGEME")]
        public uint? TimeIndex;
        
        [DBFieldName("CHANGEME")]
        public int? GameObjectsID;
    }
}
