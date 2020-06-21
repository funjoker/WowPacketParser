using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.CinematicSequences, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class CinematicSequences : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public uint? SoundID;
        
        [HotfixArray(8)]
        public ushort?[] Camera;
    }
}
