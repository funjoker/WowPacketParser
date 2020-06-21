using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CinematicCamera, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CinematicCamera : IDataModel
    {
        [HotfixArray(3, true)]
        public float?[] Origin;
        
        [DBFieldName("CHANGEME")]
        public uint? SoundID;
        
        [DBFieldName("CHANGEME")]
        public float? OriginFacing;
        
        [DBFieldName("CHANGEME")]
        public uint? FileDataID;
    }
}
