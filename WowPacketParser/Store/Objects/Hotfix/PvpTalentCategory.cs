using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.PvpTalentCategory, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class PvpTalentCategory : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public byte? TalentSlotMask;
    }
}
