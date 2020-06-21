using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SceneScriptPackage, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SceneScriptPackage : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
    }
}
