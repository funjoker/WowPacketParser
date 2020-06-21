using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.MailTemplate, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class MailTemplate : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Body;
    }
}
